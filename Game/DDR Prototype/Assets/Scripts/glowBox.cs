using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class glowBox: MonoBehaviour {

	public GameObject GlowBox; 

	int bright = 1; 
	void Start() {
        GlowBox.SetActive(false);
	}

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

//
//public class glowBox2 : MonoBehaviour {
//	public static GameObject right;
//	int glowing = 0; 
//
//	void Start() {
//	}
//
//	public void doesGlow(char bright) {
//
//		if (bright=='1') {
//			right.SetActive(true);
//		}
//	else{
//		gameObject.SetActive(false);
//	}
//
//}
//void Update() {
//}
//}
//
//public class glowBox3 : MonoBehaviour {
//	public static GameObject up;
//	int glowing = 0; 
//
//	void Start() {
//	}
//
//	public void doesGlow(char bright) {
//
//		if (bright=='1') {
//			up.SetActive(true);
//		}
//	else{
//		gameObject.SetActive(false);
//	}
//
//}
//void Update() {
//}
//}
//
//public class glowBox4 : MonoBehaviour {
//
//	public static GameObject down;
//	int glowing = 0; 
//
//	void Start() {
//	}
//
//	public void doesGlow(char bright) {
//
//		if (bright=='1') {
//			down.SetActive(true);
//		}
//		else{
//			gameObject.SetActive(false);
//		}
//
//	}
//	void Update() {
//	}
//}
