using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createArrows: MonoBehaviour {

	HashSet<GameObject> arrowActive = new HashSet<GameObject> (); 
	Queue<GameObject> arrowInactive = new Queue<GameObject> (); 

	public int arrowsCount = 100; 
	public GameObject arrowPrefab; 

	//	public GameObject leftArrow;  
	//	public GameObject rightArrow;
	//	public GameObject upArrow; 
	//	public GameObject downArrow; 

	public const int left = 1;
	public const int right = 2;
	public const int up = 3;
	public const int down = 4; 

	void Start () {
		GameObject arrow = Instantiate (arrowPrefab); 
		for (int i = 0; i < arrowsCount; i++) {
			arrowInactive.Enqueue (createGameObject()); 
		}
	}

	GameObject createGameObject(){
		GameObject arrow = Instantiate (arrowPrefab);
		arrow.gameObject.SetActive(false);
		return arrow;  
	}


	public GameObject Commission(int direction){

		switch(direction) {
		case left: 
			transform.Rotate (Vector3.forward * -90);
			// arrowPrefab = transform.position; 
			break; 

		case right: // right
			transform.Rotate (Vector3.forward * 90);
			// arrowPrefab = transform.position; 
			break; 

		case up:
			transform.Rotate (Vector3.forward * 0);
			// arrowPrefab = transform.position; 
			break; 

		case down:
			transform.Rotate (Vector3.forward * 180);
			// arrowPrefab = transform.position; 
			break;

		}

		if (arrowInactive.Count > 0) {
			GameObject arrow = arrowInactive.Dequeue ();
			arrowActive.Add (arrow);
			arrow.gameObject.SetActive (true);

			return arrow;
		} else {
			GameObject arrow = createGameObject ();
			arrowActive.Add (arrow);
			arrow.gameObject.SetActive (true);
			return arrow;
		}

	}

	public void Decommision(GameObject arrow){
		arrow.gameObject.SetActive (false);
		arrowInactive.Enqueue (arrow);
	}

	void update() {
	}

}