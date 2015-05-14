using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	float speed = 5.0f;
	float jump_speed = 5.0f;
	public int player_number = 0;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		playerMovement();
	}
	
	
	void playerMovement(){
		
		if (player_number == 1) {
			if (Input.GetKey(KeyCode.D)){
				moveRight();
			}else if(Input.GetKey(KeyCode.A)){
				moveLeft();
			}
			if (Input.GetKeyDown (KeyCode.W)){
				jump ();
			} 
		} else if (player_number == 2) {
			if (Input.GetKey(KeyCode.RightArrow)){
				moveRight();
			}else if(Input.GetKey(KeyCode.LeftArrow)){
				moveLeft();
			}
			if (Input.GetKeyDown (KeyCode.UpArrow)){
				jump ();
			}
		}
		
	}
	
	void moveRight(){
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
	
	void moveLeft(){
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
	void jump(){
		rb.velocity = new Vector3(0, jump_speed, 0);
	}
}
