using UnityEngine;
using System.Collections;

public class IronDecrease : MonoBehaviour {

	public GUIText ironText;

	void Start(){
		PreMenu.ironMax = 150;
	}

	void OnMouseDown(){
		if (PreMenu.iron > 0) {
			PreMenu.iron--;
		}
		ironText.text = PreMenu.iron.ToString() + "/" + PreMenu.ironMax.ToString();
	}
}
