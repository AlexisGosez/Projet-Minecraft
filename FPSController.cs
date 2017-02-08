/* GOSEZ Alexis
	 Projet Minecraft
-----------------------
	Script mettant en place un
	controller de type FPS
*/

﻿using UnityEngine;
using System.Collections;

public class FPSController : MonoBehaviour {

	public float vitesse;
	Vector3 position, devant, droite;

	void Update () {
		//On récupère la direction devant et à droite à chaque frame
		devant = gameObject.transform.forward;
		droite = gameObject.transform.right;

		//Z pour avancer
		if (Input.GetKey ("z")) {
			position = transform.position + vitesse * devant;
			transform.position = position;
		}

		//S pour reculer
		if (Input.GetKey ("s")) {
			position = transform.position - vitesse * devant;
			transform.position = position;
		}

		//Q pour aller à gauche
		if (Input.GetKey ("q")) {
			position = transform.position - vitesse * droite;
			transform.position = position;
		}

		//D pour aller à droite
		if (Input.GetKey ("d")) {
			position = transform.position + vitesse * droite;
			transform.position = position;
		}

		//S pour reculer
		if (Input.GetKeyDown("space")) {
			position = transform.position;
			position.y = position.y + 1.5f;
			transform.position = position;
		}

	}
}
