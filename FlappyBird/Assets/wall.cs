using UnityEngine;
using System.Collections;

public class wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += Vector3.left * 0.1f;
	}
}
