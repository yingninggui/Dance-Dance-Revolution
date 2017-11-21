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
		arrow.gameObject.SetActive(false);
		return arrow;  
	}

	Vector3 rotateArrow(int direction, Vector3 arrow){
		switch(direction) {
		case left: 
			transform.Rotate (Vector3.forward * -90);
			arrow = transform.position; 
			break; 

		case right: // right
			transform.Rotate (Vector3.forward * 90);
			arrow = transform.position; 
			break; 

		case up:
			transform.Rotate (Vector3.forward * 0);
			arrow = transform.position; 
			break; 

		case down:
			transform.Rotate (Vector3.forward * 180);
			arrow = transform.position; 
			break;

		}
		return arrow; 
	}

	public GameObject Commission(){
		if (arrowInactive.Count > 0) {
			GameObject obj = arrowInactive.Dequeue ();
			arrowActive.Add (obj);
			obj.gameObject.SetActive (true);

			return obj;
		} else {
			GameObject obj = createGameObject ();
			arrowActive.Add (obj);
			obj.gameObject.SetActive (true);
			return obj;
		}
	}

	public void Decommision(GameObject arrow){
		arrow.gameObject.SetActive (false);
		arrowInactive.Enqueue (arrow);
	}

	void update() {
	}

}

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
