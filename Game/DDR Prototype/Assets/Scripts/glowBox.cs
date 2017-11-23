using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class glowBox: MonoBehaviour {

	public GameObject GlowBox; 

	private int bright = 1; 

    /*
     * Initialize each box to not visible until user pressed game bad
     */
	void Start() {
        GlowBox.SetActive(false);
	}

    /*
     * Switch the visibility of the box
     */
	public void changeGlow() {
		if (bright > 0)
            GlowBox.SetActive(true);
	    else
            GlowBox.SetActive(false);
        bright *= -1;
    }

	void Update() {

	}
}
