﻿using UnityEngine;
using System.Collections;

public class kill_player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		
		if (other.tag == "Player") {
			other.gameObject.transform.position = new Vector3(-15.04f,2.12f,9.02f);
			//Application.LoadLevel(0);
		}
		
	}

}
