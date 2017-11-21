using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createArrows: MonoBehaviour {

	HashSet<GameObject> arrowActive = new HashSet<GameObject> (); 
	Queue<GameObject> arrowInactive = new Queue<GameObject> ();

    public Scoring score;

	public HashSet<GameObject> getActiveArrows() {
		return arrowActive; 
	} 

	public int arrowsCount = 100; 
	public GameObject arrowPrefab; 

	//	public GameObject leftArrow;  
	//	public GameObject rightArrow;
	//	public GameObject upArrow; 
	//	public GameObject downArrow; 

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
        GameObject arrow;

		if (arrowInactive.Count > 0) {
			arrow = arrowInactive.Dequeue ();
			arrowActive.Add (arrow);
			arrow.gameObject.SetActive (true);
		} else {
            arrow = createGameObject();
            arrow.gameObject.SetActive(true);
            arrowActive.Add(arrow);
        }

        switch (direction)
        {
            case SerialCommunication.LEFT:
                arrow.transform.position = new Vector3(-2.2f, 6);
                arrow.transform.Rotate(Vector3.forward * -90);
                // arrowPrefab = transform.position; 
                break;

            case SerialCommunication.DOWN:
                arrow.transform.position = new Vector3(-0.8f, 6);
                arrow.transform.Rotate(Vector3.forward * 90);
                // arrowPrefab = transform.position; 
                break;

            case SerialCommunication.UP:
                arrow.transform.position = new Vector3(0.7f, 6);
                arrow.transform.Rotate(Vector3.forward * 0);
                // arrowPrefab = transform.position; 
                break;

            case SerialCommunication.RIGHT:
                arrow.transform.position = new Vector3(2.2f, 6);
                arrow.transform.Rotate(Vector3.forward * 180);
                // arrowPrefab = transform.position; 
                break;
        }
        return arrow;
    }

	public void Decommision(GameObject arrow){
		arrow.gameObject.SetActive (false);
        arrowActive.Remove(arrow);
		arrowInactive.Enqueue (arrow);
	}

	void update() {
	}

}