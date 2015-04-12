using UnityEngine;
using System.Collections;

public class BuildingMenu : MonoBehaviour {

	public GameObject buildingMenu;
	
	// Use this for initialization
	void Start () {
		buildingMenu = GameObject.Find ("BuildingMenu");
		buildingMenu.SetActive (false);
	}
	void FixedUpdate(){
	}
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseDown(){
		
		if (!buildingMenu.activeSelf) {
			
			buildingMenu.SetActive (true);
		} else {
			buildingMenu.SetActive (false);
		}
	}
}
