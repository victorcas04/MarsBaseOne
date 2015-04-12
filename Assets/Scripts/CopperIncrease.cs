using UnityEngine;
using System.Collections;

public class CopperIncrease : MonoBehaviour {

	public GUIText copperText;

	void Start(){
		PreMenu.copperMax = 150;
		copperText.text = PreMenu.copper.ToString() + "/" + PreMenu.copperMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.copper < PreMenu.copperMax) {
			PreMenu.copper++;
		}
		copperText.text = PreMenu.copper.ToString() + "/" + PreMenu.copperMax.ToString();
	}
}
