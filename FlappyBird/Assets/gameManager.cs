using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	public static bool gameOver;
	void Awake(){
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver && Input.GetMouseButton(0)){
			Application.LoadLevel("main");
		}
	}
}
