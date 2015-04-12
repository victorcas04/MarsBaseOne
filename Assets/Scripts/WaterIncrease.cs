using UnityEngine;
using System.Collections;

public class WaterIncrease : MonoBehaviour {

	public GUIText waterText;

	void Start(){
		PreMenu.waterMax = 100;
		waterText.text = PreMenu.water.ToString() + "/" + PreMenu.waterMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.water < PreMenu.waterMax) {
			PreMenu.water++;
		}
		waterText.text = PreMenu.water.ToString() + "/" + PreMenu.waterMax.ToString();
	}
}
