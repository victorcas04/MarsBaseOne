using UnityEngine;
using System.Collections;

public class ExplorationTunel4: MonoBehaviour {

	public GameObject explorationActive;

	void OnMouseDown(){
			explorationActive.SetActive (true);
	}

	void OnMouseUp(){
		Application.LoadLevel ("Map4");
	}
}
