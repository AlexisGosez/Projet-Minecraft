/* GOSEZ Alexis
	 Projet Minecraft
-----------------------
	Script permettant de
	faire apparaître un
	réticule au centre de l'écran
*/

﻿using UnityEngine;
using System.Collections;

public class Reticule : MonoBehaviour {

	Vector2 position;
	Rect rectangle;

	void Start () {
		position.Set (Screen.width * 0.5f, Screen.height * 0.5f);
		rectangle.Set (position.x, position.y, 200.0f, 200.0f);
	}

	void OnGUI () {
		GUI.Label (rectangle, "+");
	}
}
