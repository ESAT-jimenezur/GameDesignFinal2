using UnityEditor;
using UnityEngine;
using System.Collections;

public class collectible_object : MonoBehaviour {

	public int collectible_by_player_n = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if(collectible_by_player_n == 1){
			if (other.gameObject.name == "Player 1") {
				Level1.collected_blue_objects++;
				Destroy (gameObject);
			}
		}else if(collectible_by_player_n == 2){
			if (other.gameObject.name == "Player 2") {
				Level1.collected_red_objects++;
				Destroy (gameObject);
			}
		}

	}


}
