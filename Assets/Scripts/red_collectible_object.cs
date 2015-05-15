using UnityEngine;
using UnityEditor;
using UnityEngine;
using System.Collections;

public class red_collectible_object : MonoBehaviour {
	
	// Use this for initializations
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.name == "Player 2") {
			Destroy (gameObject);
			LevelManager.collected_red_objects = LevelManager.getCollectedRedObjects() + 1;
		}
		
	}
	
	
}
