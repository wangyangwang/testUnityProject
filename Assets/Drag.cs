using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.frameCount % 100 == 0) {
			StartCoroutine ("DragMe");
		}
	}


	IEnumerator DragMe() {
		for (int i = 0; i < 10; i++) {
			transform.Translate (new Vector3 (0, 0, -0.4f), Space.World);
			transform.RotateAround (transform.position, Vector3.right, 10.0f);
			yield return new WaitForSeconds (0.01f);
		}
		transform.RotateAround (transform.position,Vector3.right, -100.0f);
	}

		
}
