﻿using UnityEngine;
using System.Collections;

public class ParticleSortlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Change Foreground to the layer you want it to display on 
        //You could prob. make a public variable for this
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Foreground";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
