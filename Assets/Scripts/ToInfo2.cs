using UnityEngine;
using System.Collections;

public class ToInfo2 : MonoBehaviour{

	public GameObject menu;
	
	void OnMouseDown(){
		Application.OpenURL ("http://www.google.com");
		menu.SetActive (false);
	}
}

