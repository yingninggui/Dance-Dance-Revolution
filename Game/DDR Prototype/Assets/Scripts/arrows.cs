using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

	public float dropSpeed = 1f; 

	void Start () {
	}

	void Update () {
		float tracker = 1f; 

		while (tracker > 0) {
			transform.Translate (Vector3.down * dropSpeed * Time.deltaTime); 
			tracker -= 1; 
			Vector3 leftArrow = transform.position;
			Vector3 rightArrow = transform.position;
			Vector3 upArrow = transform.position;
			Vector3 downArrow = transform.position;

			if (transform.position.y == 0) {
				break; 
			}
		}
	}
}
