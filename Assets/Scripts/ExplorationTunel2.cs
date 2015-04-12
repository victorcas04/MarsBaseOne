using UnityEngine;
using System.Collections;

public class ExplorationTunel2: MonoBehaviour {

	public GameObject explorationActive;

	void OnMouseDown(){
			explorationActive.SetActive (true);
	}

	void OnMouseUp(){
		Application.LoadLevel ("Map2");
	}
}
