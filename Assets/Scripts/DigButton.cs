using UnityEngine;
using System.Collections;

public class DigButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		GameObject.Destroy (gameObject.transform.parent.gameObject);
	}
}
