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
		Debug.Log ("Trigger Enter");
		if (other.gameObject.name == "Player 1") {
			Debug.Log ("IF");
			Debug.Log (other.gameObject.name);
			Destroy (gameObject);
		}
	}


}
