using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowLeft : MonoBehaviour {

	public float dropSpeed = 1f; 
	public GameObject theLeftArrow;  

	void Start () {

	}

	void Update () {

		float tracker = 10f;

		while (tracker > 0) {
			transform.Translate (Vector3.down * dropSpeed * Time.deltaTime); 
			tracker -= 1; 
			Vector3 theLeftArrow = transform.position;

			if (transform.position.y == 0) {
				break; 
			}
		}
	}
}
