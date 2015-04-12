using UnityEngine;
using System.Collections;

public class OxygenDecrease : MonoBehaviour {

	public GUIText oxygenText;

	void Start(){
		PreMenu.oxygenMax = 250;
	}

	void OnMouseDown(){
		if (PreMenu.oxygen > 0) {
			PreMenu.oxygen--;
		}
		oxygenText.text = PreMenu.oxygen.ToString() + "/" + PreMenu.oxygenMax.ToString();
	}
}
