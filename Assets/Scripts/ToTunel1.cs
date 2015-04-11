using UnityEngine;
using System.Collections;

public class ToTunel1: MonoBehaviour {

	public GameObject menu;

	void OnMouseDown(){
		Application.LoadLevel ("Tunel1");
		menu.SetActive (false);
	}
}
