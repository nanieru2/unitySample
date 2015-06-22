using UnityEngine;
using System.Collections;

public class WallBuilder : MonoBehaviour {

	[SerializeField]
	GameObject wallPrefab;

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			Instantiate (wallPrefab, Vector3.right * 10, Quaternion.identity);
			yield return new WaitForSeconds (2f);
		} 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
