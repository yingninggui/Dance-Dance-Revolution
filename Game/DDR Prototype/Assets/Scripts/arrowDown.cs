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

		float tracker=1f;
//		float newPosition; 

<<<<<<< HEAD:Game/DDR Prototype/Assets/Scripts/arrowDown.cs
		transform.Translate (Vector3.right * 3 * Time.deltaTime); 

		System.Threading.Thread.Sleep(100);

		//System.Threading.Thread.Sleep(100);

=======
		transform.Translate (Vector3.right * 3 * Time.deltaTime);
>>>>>>> dd340c8f51c1eee259c4a3e6f4da294807c2fdc7:Game/DDR Prototype/Assets/Graphics/arrowDown.cs
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
