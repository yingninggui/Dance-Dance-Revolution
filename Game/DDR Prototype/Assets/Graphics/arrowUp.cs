﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowUp : MonoBehaviour {

	public float dropSpeed = 1f; 
	public GameObject theUpArrow;  

	void Start () {

	}

	void Update () {

		float tracker = 10f;

		transform.Translate (Vector3.left * 1 * Time.deltaTime); 
		System.Threading.Thread.Sleep(100);

		while (tracker > 0) {
			transform.Translate (Vector3.down * dropSpeed * Time.deltaTime); 
			tracker -= 1; 
			Vector3 theUpArrow = transform.position;

			if (transform.position.y == 0) {
				break; 
			}
		}
	}
}