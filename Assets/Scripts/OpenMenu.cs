using UnityEngine;
using System.Collections;

public class OpenMenu : MonoBehaviour
{
	public GameObject menu;

	void OnMouseDown(){
		menu.SetActive (true);
	}
}

