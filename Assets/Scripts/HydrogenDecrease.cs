using UnityEngine;
using System.Collections;

public class HydrogenDecrease : MonoBehaviour {

	public GUIText hydrogenText;

	void Start(){
		PreMenu.hydrogenMax = 250;
	}

	void OnMouseDown(){
		if (PreMenu.hydrogen > 0) {
			PreMenu.hydrogen--;
		}
		hydrogenText.text = PreMenu.hydrogen.ToString() + "/" + PreMenu.hydrogenMax.ToString();
	}
}
