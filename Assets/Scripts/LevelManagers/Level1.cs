using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {
	
	private static Level1 _instance;

	public int total_red_objects = 3;
	public int total_blue_objects = 3;

	public static int collected_red_objects = 0;
	public static int collected_blue_objects = 0;

	GameObject door;
	
	public static Level1 instance{
		get{
			
			if(_instance == null){
				_instance = GameObject.FindObjectOfType<Level1>();
			}
			return _instance;
		}
	}
	
	public static void init(){
		Debug.Log ("Level Manager Started --Level 1--");
	}
	
	void Awake () {
		if(_instance == null){
			_instance = this;
			init ();

			door = GameObject.Find ("Door");

		}else{
			Destroy(gameObject);
		}
	}
	
	public static void Restart(){

	}

	
	void Update(){
		if (collected_blue_objects >= total_blue_objects && 
		    collected_red_objects >= total_red_objects) {
			Destroy (door);
		}
	}
	
}