using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createArrows: MonoBehaviour {
	
	// instantiate queue of arrows 
	HashSet<GameObject> arrowActive = new HashSet<GameObject> (); 
	Queue<GameObject> arrowInactive = new Queue<GameObject> ();

    public Scoring score;

	public HashSet<GameObject> getActiveArrows() {
		return arrowActive; 
	} 

	// will increase number of arrows according to song 
	public int arrowsCount = 100; 

	// initial the arrow to be manipulated/copied 
	public GameObject arrowPrefab; 

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

    /*
     * Commision previously loaded arrow from inactive arrow queue provided 
     * one exists, otherwise, load new arrow and add to active arrows queue
     */
	public GameObject Commission(int direction){
        GameObject arrow;

		if (arrowInactive.Count > 0) {
			arrow = arrowInactive.Dequeue ();
			arrowActive.Add (arrow);
		} else {
            arrow = createGameObject();
            arrowActive.Add(arrow);
        }

	// Rotate arrows to specified angle
        switch (direction){
            case SerialCommunication.LEFT:
                arrow.transform.position = new Vector3(-2.2f, 6, 0);
                arrow.transform.Rotate(0, 0, 90);
                break;

            case SerialCommunication.DOWN:
                arrow.transform.position = new Vector3(-0.7f, 6, 0);
                arrow.transform.Rotate(0, 0, 180);
                break;

            case SerialCommunication.UP:
                arrow.transform.position = new Vector3(0.8f, 6, 0);
                break;

            case SerialCommunication.RIGHT:
                arrow.transform.position = new Vector3(2.2f, 6, 0);
                arrow.transform.Rotate(0, 0, 270);
                break;
        }
        arrow.gameObject.SetActive(true);
        return arrow;
    }

    /*
     * Remove arrow from active queue, add it to inactive queue for future use,
     * and remove from game view
     */
	public void Decommision(GameObject arrow){
		arrow.gameObject.SetActive (false);
        arrowActive.Remove(arrow);
		arrowInactive.Enqueue (arrow);
	}

	void update() {
	}

}