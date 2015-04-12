using UnityEngine;
using System.Collections;

public class CharCollider : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {

		this.transform.parent.SendMessage ("OnCollisionEnter2DChild", coll);
	}
}
