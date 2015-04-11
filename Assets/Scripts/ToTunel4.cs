using UnityEngine;
using System.Collections;

public class ToTunel4: MonoBehaviour {

	public GameObject menu;
	
	void OnMouseDown(){
		Application.LoadLevel ("Tunel4");
		menu.SetActive (false);
	}
}
