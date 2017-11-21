using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createArrows: MonoBehaviour {

	HashSet<GameObject> arrowActive = new HashSet<GameObject> (); 
	Queue<GameObject> arrowInactive = new Queue<GameObject> (); 

	public int arrowsCount = 100; 
	public GameObject arrowPrefab; 
//
//	public GameObject leftArrow;  
//	public GameObject rightArrow;
//	public GameObject upArrow; 
//	public GameObject downArrow; 
//
	public const int left = 1;
	public const int right = 2;
	public const int up = 3;
	public const int down = 4; 


	void Start () {

		GameObject arrow = Instantiate (arrowPrefab); 

		for (int i = 0; i < arrowsCount; i++) {
			arrowInactive.Enqueue (createGameObject ()); 
		}
	}

	GameObject createGameObject(){
		GameObject arrow = Instantiate (arrowPrefab); 
		arrow.transform.GetComponentInParent = transform; 
		arrow.gameObject.SetActive(false);

		switch(direction) {
			case left: 
				arrow = transform.Rotate (270); 
				break; 

			case right: // right
				arrow = transform.Rotate(90); 
				break; 

			case up:
				arrow = transform.Rotate(0); 
				break; 

			case down:
				transform.Rotate(180); 
				break;

		}

		return arrow;  
	}


}

public class arrows : MonoBehaviour {

	public float dropSpeed = 1f; 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
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

	void generateArrows() {
		
		
	}

}
