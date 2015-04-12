using UnityEngine;
using System.Collections;

public class ExplorationTunel3: MonoBehaviour {

	public GameObject explorationActive;

	void OnMouseDown(){
			explorationActive.SetActive (true);
	}

	void OnMouseUp(){
		Application.LoadLevel ("Map3");
	}
}
