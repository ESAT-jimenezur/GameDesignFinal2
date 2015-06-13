using UnityEngine;
using System.Collections;

public class blue_collectible_object : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.name == "Player 1") {
			Destroy (gameObject);
			LevelManager.collected_blue_objects = LevelManager.getCollectedBlueObjects() + 1;
		}

	}


}
