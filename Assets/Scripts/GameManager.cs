using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	private static GameManager _instance;

	
	public static GameManager instance{
		get{
			
			if(_instance == null){
				_instance = GameObject.FindObjectOfType<GameManager>();
			}
			return _instance;
		}
	}
	
	public static void init(){
		Debug.Log ("Game Manager Started");
	}
	
	void Awake () {
		if(_instance == null){
			_instance = this;
			init ();
		}else{
			Destroy(gameObject);
		}
	}
	
	public static void Restart(){

	}
	
	
	void Update(){
		
	}
	
}