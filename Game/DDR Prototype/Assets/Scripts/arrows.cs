using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

	public float dropSpeed = 1f;

    public GameObject ArrowUp;

    public createArrows create;

    public const float GLOW_BOX_HEIGHT = -3.5f;

	void Start () {
	}

	void Update () {
		float tracker = dropSpeed; 

		while (tracker > 0 && transform.position.y > GLOW_BOX_HEIGHT) {
            transform.Translate (Vector3.down * dropSpeed * Time.deltaTime); 
			tracker -= 1; 
		}

        //Debug.Log(transform.position.y);

        if (transform.position.y <= GLOW_BOX_HEIGHT)
            create.Decommision(ArrowUp);

	}
}
