using UnityEngine;
using System.Collections;

public class door_finish_level : MonoBehaviour {
	
	bool player_blue_inside = false;
	bool player_red_inside = false;
	public Canvas player1;
	public Canvas player2;

	void Start(){
		player1.enabled = false;
		player2.enabled = false;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Player 1") {
			player_blue_inside = true;
		}
		if (other.gameObject.name == "Player 2") {
			player_red_inside = true;
		}
	}


	void FixedUpdate(){
		Debug.Log ("A" + LevelManager.getCollectedBlueObjects());
		if(player_blue_inside){
			player1.enabled = true;
		}
		if(player_red_inside){
			player2.enabled = true;
		}
	}

}
