using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

    HashSet<GameObject> set;

    public ArrowCreation create;
    public score sc;

    public const int HIT_POINTS = 5, MISS_POINTS = -1;
    public const float BOUNDARY_HEIGHT = -2.5f;

    private int total_score, total_hits, total_misses;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void pressedKey(int key)
    {
        if (create.getActiveArrows()[key].Peek().transform.position.y <= BOUNDARY_HEIGHT)
        {
            total_hits++;
            create.removeArrow(create.getActiveArrows()[key].Dequeue());
        }
        else
            total_misses++;

        sc.SetScore(total_hits, total_misses);
    }
}
