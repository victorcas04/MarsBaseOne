using UnityEngine;
using System.Collections;

public class HydrogenIncrease : MonoBehaviour {

	public GUIText hydrogenText;

	void Start(){
		PreMenu.hydrogenMax = 250;
		hydrogenText.text = PreMenu.hydrogen.ToString() + "/" + PreMenu.hydrogenMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.hydrogen < PreMenu.hydrogenMax) {
			PreMenu.hydrogen++;
		}
		hydrogenText.text = PreMenu.hydrogen.ToString() + "/" + PreMenu.hydrogenMax.ToString();
	}
}
