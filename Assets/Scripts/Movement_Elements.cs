using UnityEngine;
using System.Collections;

public class Movement_Elements : MonoBehaviour {
	float verticalspeed = 5.0f;
	float control_var = 0.0f;
	Rigidbody rectangle;
	// Use this for initialization
	void Start () {
		rectangle = GetComponent<Rigidbody>();
		control_var = 0.0f;
	}
	
	void MoveElements() {
		if (control_var >= 0.0f) {
			MoveUp ();
		} else if (control_var >= 10.0f) {
			MoveDown ();
		}
	}
	
	// Update is called once per frame
	void MoveUp(){
		transform.Translate (Vector3.up * verticalspeed * Time.deltaTime);
		control_var++;
	}
	void MoveDown() {
		transform.Translate (Vector3.down * verticalspeed * Time.deltaTime);
		control_var--;
	}
	
	void Update () {
		
		MoveElements ();
	}
	
}