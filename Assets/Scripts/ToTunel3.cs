using UnityEngine;
using System.Collections;

public class ToTunel3: MonoBehaviour {

	public GameObject menu;
	
	void OnMouseDown(){
		Application.LoadLevel ("Tunel3");
		menu.SetActive (false);
	}
}
