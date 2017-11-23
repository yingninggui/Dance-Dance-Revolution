using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

	public float dropSpeed = 1f;

    public GameObject ArrowUp;

    public ArrowCreation create;

    public const float GLOW_BOX_HEIGHT = -3.5f;

	void Start () {
	}

	void Update () {
		float tracker = dropSpeed; 

		while (tracker > 0 && transform.position.y > GLOW_BOX_HEIGHT) {
            Vector3 temp = transform.position;
            temp.y -= dropSpeed * Time.deltaTime;
            transform.position = temp; 
			tracker -= 1;
		}

        //Debug.Log(transform.position.y);

        if (transform.position.y <= GLOW_BOX_HEIGHT)
            create.removeArrow(ArrowUp);

	}
}
