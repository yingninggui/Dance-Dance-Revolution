using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrows : MonoBehaviour {

	public float dropSpeed = 1f;

    public GameObject ArrowUp;

    public ArrowCreation create;

    /*
     * Ending height of glow box, used to determine if arrow have 
     * reached end of game field
     */
    public const float GLOW_BOX_HEIGHT = -3.5f;

	void Start () {
	}

	void Update () {
		float tracker = dropSpeed; 

        // Move arrow down by one pixel each frame, checking if passing below the glow boxes
		while (tracker > 0 && transform.position.y > GLOW_BOX_HEIGHT) {
            Vector3 temp = transform.position;
            temp.y -= dropSpeed * Time.deltaTime;
            transform.position = temp; 
			tracker -= 1;
		}
    
        // Remove arrow from screen provided it passes glow boxes without being tapped by user
        if (transform.position.y <= GLOW_BOX_HEIGHT)
            create.removeArrow(ArrowUp);

	}
}
