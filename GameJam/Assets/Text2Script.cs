﻿using UnityEngine;
using System.Collections;

public class Text2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void loadLevel(){
		Application.LoadLevel ("Test");
	}

	void Exit () {
		Application.Quit ();
	}
}
