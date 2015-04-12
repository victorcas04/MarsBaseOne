using UnityEngine;
using System.Collections;

public class CopperDecrease : MonoBehaviour {

	public GUIText copperText;

	void Start(){
		PreMenu.copperMax = 150;
	}

	void OnMouseDown(){
		if (PreMenu.copper > 0) {
			PreMenu.copper--;
		}
		copperText.text = PreMenu.copper.ToString() + "/" + PreMenu.copperMax.ToString();
	}
}
