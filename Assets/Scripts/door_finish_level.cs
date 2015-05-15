using UnityEngine;
using System.Collections;

public class door_finish_level : MonoBehaviour {
	
	bool player_blue_inside = false;
	bool player_red_inside = false;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Player 1") {
			player_blue_inside = true;
		}
		if (other.gameObject.name == "Player 2") {
			player_red_inside = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.name == "Player 1") {
			player_blue_inside = false;
		}
		if (other.gameObject.name == "Player 2") {
			player_red_inside = false;
		}
	}


	void FixedUpdate(){
		Debug.Log ("A" + LevelManager.getCollectedBlueObjects());
		if(player_blue_inside && player_red_inside){

			Application.LoadLevel(0);
		}
	}

}
