using UnityEngine;
using System.Collections;

public class OxygenIncrease : MonoBehaviour {

	public GUIText oxygenText;

	void Start(){
		PreMenu.oxygenMax = 250;
		oxygenText.text = PreMenu.oxygen.ToString() + "/" + PreMenu.oxygenMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.oxygen < PreMenu.oxygenMax) {
			PreMenu.oxygen++;
		}
		oxygenText.text = PreMenu.oxygen.ToString() + "/" + PreMenu.oxygenMax.ToString();
	}
}
