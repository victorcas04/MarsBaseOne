using UnityEngine;
using System.Collections;

public class IronIncrease : MonoBehaviour {

	public GUIText ironText;

	void Start(){
		PreMenu.ironMax = 150;
		ironText.text = PreMenu.iron.ToString() + "/" + PreMenu.ironMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.iron < PreMenu.ironMax) {
			PreMenu.iron++;
		}
		ironText.text = PreMenu.iron.ToString() + "/" + PreMenu.ironMax.ToString();
	}
}
