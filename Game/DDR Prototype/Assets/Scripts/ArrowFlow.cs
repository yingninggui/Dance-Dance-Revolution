using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

// arrow type 
public enum StandardControls{
	left,
	right,
	up,
	down
}

// load images and let them drop continuously 

public class MovingArrows : MonoBehaviour {

	public int dropSpeed = 1;

	private BoxCollider2D boxCollider; 
	private Rigidbody2D rb2D; 



	public Vector3 userDirection = Vector2.down;

	private GameObject Arrow; 
	// Use this for initialization

	protected virtual void Start () { 

		boxCollider = GetComponent<BoxCollider2D> ();

		// NEED TO MAKE ARROWS FALL I CANT UNITY GIMME A SEC

	}

	protected IEnumerator SmoothMOvement (Vector3 end){
		float sqrRemainingDistance = (transform.position - end).sqrMagnitude; 
		while (sqrRemainingDistance > float.Epislon) {
			Vector3 newPosition = Vector3.MoveTowards 
		}
	}

	void Update () {

		int yPosition=20, xPosition=20; 
			
		while (yPosition > 100) {

			transform.Translate (userDirection * dropSpeed * 10); 
			yPosition -= dropSpeed * 10; 
		} 
		// INSERT EXIT POINT TO MAKE ARROWS STOP FALLING 
		
	}
}

// afterthoughts: method for glowing grid, score keeper 
