﻿using UnityEngine;
using System.Collections;

public class Movement_Elements_Horizontal : MonoBehaviour {
	
	private bool up;
	private bool down;
	public float range;
	int tmp_rand_Value;
	float init_pos;
	
	
	// Use this for initialization
	void Start () {
		tmp_rand_Value = Random.Range(0, 2);
		if (tmp_rand_Value == 1) {
			up = true;
			down = false;
		}if (tmp_rand_Value == 0) {
			up = false;
			down = true;
		}
		init_pos = transform.position.x;
	}
	
	void MoveElements() {
		if (transform.position.x >= init_pos+range) {
			down = true;
			up= false;
		} else if (transform.position.x <= (init_pos+(range*-1))) {
			down = false;
			up= true;
		}
		if (up) {
			MoveUp ();
		}
		if (down) {
			MoveDown ();
		}
	}
	
	// Update is called once per frame
	void MoveUp(){
		transform.Translate(Vector3.right/30);
	}
	void MoveDown() {
		transform.Translate (Vector3.left/30);
	}
	
	void Update () {
		
		MoveElements ();
	}
	
}