using UnityEngine;
using System.Collections;

public class ToInfo3 : MonoBehaviour{

	public GameObject menu;
	
	void OnMouseDown(){
		Application.OpenURL ("http://www.google.com");
		menu.SetActive (false);
	}
}

