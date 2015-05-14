using UnityEditor;
using UnityEngine;
using System.Collections;

public class collectible_object : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Player 1") {
			Level1.collected_blue_objects++;
			Destroy (gameObject);
		}
	}


}
