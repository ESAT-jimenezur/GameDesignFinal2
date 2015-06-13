using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	float speed = 5.0f;
	float jump_speed = 6.0f;
	public int player_number = 0;
	Rigidbody rb;
	bool ground;
	bool jumpdone;
	bool jump2done;

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
			if (Input.GetKeyDown (KeyCode.W)){
				jump ();
			} 
			if (Input.GetKey(KeyCode.D)){
				moveRight();
			}else if(Input.GetKey(KeyCode.A)){
				moveLeft();
			}
		} else if (player_number == 2) {
			if (Input.GetKeyDown (KeyCode.UpArrow)){
				jump ();
			}
			if (Input.GetKey(KeyCode.RightArrow)){
				moveRight();
			}
			else if(Input.GetKey(KeyCode.LeftArrow)){
				moveLeft();
			}
		}
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Ground") {
			ground = true;
			jumpdone = jump2done = false;
		}
		if (other.tag == "Player") {
			ground = true;
			jumpdone = jump2done = false;
		}
	}

	void moveRight(){
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
	
	void moveLeft(){
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
	void jump(){
		if (ground && !jump2done && !jumpdone) {
			rb.velocity = new Vector3 (0, jump_speed, 0);
			jumpdone = true;
		}
		else if(jumpdone && !jump2done){
			rb.velocity = new Vector3 (0, jump_speed, 0);
			jump2done = true;
		}
	}
}
