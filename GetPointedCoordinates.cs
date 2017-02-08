/* GOSEZ Alexis
	 Projet Minecraft
-----------------------
	Script permettant de faire
	apparaître un bloc juxtaposé
	à un autre lors d'un clic
*/

﻿using UnityEngine;
using System.Collections;

public class GetPointedCoordinates : MonoBehaviour {

	Camera camera;
	RaycastHit hit;
	Vector3 posObjet, posCam, centreEcran;
	float distanceCam;
	public GameObject Bloc;

	void Start() {
		//On récupère la caméra de la scène
		camera = GameObject.FindObjectOfType<Camera>();
		posCam = camera.transform.position;
		centreEcran.Set((Screen.width)*0.5f, (Screen.height)*0.5f, 0);

	}

	void Update()
	{
		Vector3 position;

		//On récupère la position pointée
		if (Physics.Raycast(camera.ScreenPointToRay(centreEcran).origin, camera.ScreenPointToRay(centreEcran).direction,
			out hit, 15.0f, Physics.DefaultRaycastLayers, QueryTriggerInteraction.UseGlobal))
		{
			position = hit.point;									//Position pointée
			posObjet = hit.collider.gameObject.transform.position;	//Position de l'objet pointé

			//On fait en sorte que le cube qu'on veut faire apparaître se place sur le côté du cube pointé
			if (position.x == posObjet.x - 0.5 || position.x == posObjet.x + 0.5)
			{
				position.x = 2 * position.x - posObjet.x;
				position.y = posObjet.y;
				position.z = posObjet.z;
			}

			if (position.y == posObjet.y - 0.5 || position.y == posObjet.y + 0.5)
			{
				position.x = posObjet.x;
				position.y = 2 * position.y - posObjet.y;
				position.z = posObjet.z;
			}

			if (position.z == posObjet.z - 0.5 || position.z == posObjet.z + 0.5)
			{
				position.x = posObjet.x;
				position.y = posObjet.y;
				position.z = 2 * position.z - posObjet.z;
			}

			distanceCam = (position - posCam).magnitude;

			//Le cube apparaît quand on clique
			if (Input.GetButtonDown ("Fire1") && distanceCam > 1)
			{
				Instantiate (Bloc, position, hit.collider.transform.rotation);
			}

		}

	}

}
