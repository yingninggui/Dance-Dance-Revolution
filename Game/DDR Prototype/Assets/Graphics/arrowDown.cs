using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//public Point Location { get; set; }

public class arrowDown : MonoBehaviour {

	public float dropSpeed = 1f; 
	public GameObject theDownArrow;  

	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		float tracker=10f;
//		float newPosition; 

		transform.Translate (Vector3.right * 3 * Time.deltaTime); 
		System.Threading.Thread.Sleep(100);

		while (tracker >= 0) {
			transform.Translate (Vector3.down * dropSpeed * Time.deltaTime); 
			tracker -= 1; 
			Vector3 theDownArrow = transform.position;

			if (transform.position.y == 0) {
				break; 
			}

		}
					
	}


}
