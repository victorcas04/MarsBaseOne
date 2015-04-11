using UnityEngine;
using System.Collections;

public class ToTunel2: MonoBehaviour {

	public GameObject menu;
	
	void OnMouseDown(){
		Application.LoadLevel ("Tunel2");
		menu.SetActive (false);
	}
}
