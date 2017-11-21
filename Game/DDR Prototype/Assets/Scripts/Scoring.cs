using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

    HashSet<GameObject> set;

    createArrows create;

    public const int HIT_POINTS = 5, MISS_POINTS = -1;

    public Queue

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pressedKey(int key)
    {
        switch(key)
        {
            case SerialCommunication.UP:
                break;
            case SerialCommunication.DOWN:
                break;
            case SerialCommunication.LEFT:
                break;
            case SerialCommunication.RIGHT:
                break; 
        }
    }
}
