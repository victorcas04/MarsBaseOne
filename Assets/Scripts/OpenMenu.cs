using UnityEngine;
using System.Collections;

public class OpenMenu : MonoBehaviour{

	public GameObject exitMenu;
	public GameObject tubeMenu;

	void OnMouseDown(){
		if (!exitMenu.activeSelf) {
			tubeMenu.SetActive (true);
		}
	}

	void Update(){
		if(tubeMenu.activeSelf && Input.GetKeyDown("escape")){
			tubeMenu.SetActive(false);
		} else if(!exitMenu.activeSelf && !tubeMenu.activeSelf && Input.GetKeyDown("escape")){
			exitMenu.SetActive (true);
		}else if (exitMenu.activeSelf && Input.GetKeyDown ("escape")) {
			exitMenu.SetActive (false);
		}
	}
}

