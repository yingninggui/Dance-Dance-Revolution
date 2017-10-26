using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Visibility; 
 

public class glowBox : MonoBehaviour{
	public GameObject glow;
	int glowing = 0; 

	void Start() {
		
	}

	void doesGlow(int bright) {

		if (bright==0) {
			gameObject.SetActive(false);

		}
		else{
			gameObject.SetActive(true);
			Debug.Log ("hello"); 
		}

	}

	void Update() {
		doesGlow (1); 
	}
//	Image glowing;
//	int tap = 0; 
//
//	void Start()
//	{
//		glowing = GetComponent<Image>();
//	}
//
//	void glow()
//	{
//		if (tap == 0) {
//			glowing.Visibility = Visibility.Collapsed;
//		} else { 
//			glowing.Visibility = Visibility.Visible;
//		}
//	}
}