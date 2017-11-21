using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

	public float dropSpeed = 1f;

    public GameObject ArrowUp;

    createArrows create;

	void Start () {
	}

	void Update () {
		float tracker = dropSpeed; 

		while (tracker > 0 && transform.position.y > -3) {
            transform.Translate (Vector3.down * dropSpeed * Time.deltaTime); 
			tracker -= 1; 
		}

        //Debug.Log(transform.position.y);

        if (transform.position.y <= -3)
            create.Decommision(ArrowUp);

	}
}
