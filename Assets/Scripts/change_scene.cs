using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class change_scene : MonoBehaviour {

	public void changeToScene(int scene){
		Application.LoadLevel (scene);
	}

}
