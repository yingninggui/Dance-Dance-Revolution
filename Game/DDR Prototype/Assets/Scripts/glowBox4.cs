using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowBox4 : MonoBehaviour {
	public GameObject glow;
	int glowing = 0; 

	void Start() {
	}

	public void doesGlow(char bright) {

		if (bright=='0') {
			gameObject.SetActive(true);

		}
		else{
			gameObject.SetActive(false);
		}

	}

	void Update() {
	}
}
