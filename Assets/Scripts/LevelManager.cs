using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	private static LevelManager _instance;

	public int level_number = 0;

	public int total_red_objects = 3;
	public int total_blue_objects = 3;

	public static int collected_red_objects = 0;
	public static int collected_blue_objects = 0;

	GameObject door;
	
	public static LevelManager instance{
		get{
			
			if(_instance == null){
				_instance = GameObject.FindObjectOfType<LevelManager>();
			}
			return _instance;
		}
	}
	
	public static void init(){
		Debug.Log ("** Level Manager Started ***");
	}
	
	void Awake () {
		if(_instance == null){
			_instance = this;
			init ();

			collected_blue_objects = 0;
			collected_red_objects = 0;
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

	public static int getCollectedBlueObjects(){
		return collected_blue_objects;
	}

	public static int getCollectedRedObjects(){
		return collected_red_objects;
	}
}