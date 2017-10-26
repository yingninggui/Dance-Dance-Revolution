using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows.Visibility; 

public class glowBox : MonoBehaviour{
	Image glowing;
	int tap = 0; 

	void Start()
	{
		glowing = GetComponent<Image>();
	}

	void glow()
	{
		if (tap == 0) {
			glowing.Visibility = Visibility.Collapsed;
		} else { 
			glowing.Visibility = Visibility.Visible;
		}
	}
}