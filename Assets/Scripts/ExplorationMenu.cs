using UnityEngine;
using System.Collections;

public class ExplorationMenu : MonoBehaviour {

	public GameObject explorationMenu;
	
	// Use this for initialization
	void Start () {
		explorationMenu = GameObject.Find ("ExplorationMenu");
		explorationMenu.SetActive (false);
	}
	void FixedUpdate(){
	}
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseDown(){
		
		if (!explorationMenu.activeSelf) {
			
			explorationMenu.SetActive (true);
			Application.LoadLevel("Map1");
		} else {
			explorationMenu.SetActive (false);
		}
	}
}
