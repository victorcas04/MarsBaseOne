using UnityEngine;
using System.Collections;

public class AstronautMenu : MonoBehaviour {

	public GameObject astronautMenu;
	
	// Use this for initialization
	void Start () {
		astronautMenu = GameObject.Find ("AstronautMenu");
		astronautMenu.SetActive (false);
	}
	void FixedUpdate(){
	}
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseDown(){
		
		if (!astronautMenu.activeSelf) {
			
			astronautMenu.SetActive (true);
		} else {
			astronautMenu.SetActive (false);
		}
	}
}
