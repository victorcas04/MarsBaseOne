using UnityEngine;
using System.Collections;

public class WaterDecrease : MonoBehaviour {

	public GUIText waterText;

	void Start(){
		PreMenu.waterMax = 100;
	}

	void OnMouseDown(){
		if (PreMenu.water > 0) {
			PreMenu.water--;
		}
		waterText.text = PreMenu.water.ToString() + "/" + PreMenu.waterMax.ToString();
	}
}
