using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GetComponent<Rigidbody2D> ().velocity += Vector2.up * 10;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		Debug.Log ("GAME OVER!");
		Destroy (gameObject);
		gameManager.gameOver = true;
	}
} 
