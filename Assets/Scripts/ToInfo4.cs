using UnityEngine;
using System.Collections;

public class ToInfo4 : MonoBehaviour{

	public GameObject menu;
	
	void OnMouseDown(){
		Application.OpenURL ("http://mars.nasa.gov/allaboutmars/");
		menu.SetActive (false);
	}
}

