using UnityEngine;
using System.Collections;

public class ToNewGame : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel ("NewGame");
	}
}
