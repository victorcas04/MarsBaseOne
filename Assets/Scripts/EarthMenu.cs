using UnityEngine;
using System.Collections;

public class EarthMenu : MonoBehaviour {

	public GameObject earthMenu;

	// Use this for initialization
	void Start () {
		earthMenu = GameObject.Find ("EarthMenu");
		earthMenu.SetActive (false);
	}
	void FixedUpdate(){
	}
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseDown(){

			if (!earthMenu.activeSelf) {
			
				earthMenu.SetActive (true);
			} else {
				earthMenu.SetActive (false);
			}
		}
}
