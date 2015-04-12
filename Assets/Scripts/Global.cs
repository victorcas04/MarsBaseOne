using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {

	public bool showMenu = false;
	public bool showInterfaceMenu = false;
	public GameObject actualPlayer;
	public GameObject[] players;
	public GameObject selectedBlock;

	// Use this for initialization
	void Start () {
	
		players = GameObject.FindGameObjectsWithTag ("Character");
		Debug.Log (players.Length.ToString());

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("1")) {
			Debug.Log ("Entro en el input");
			foreach (GameObject playerFound in players) {
				if (playerFound.name.Equals ("Recolector")) {
					playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().active = true;
					actualPlayer = playerFound.transform.parent.gameObject;
					Debug.Log (playerFound.name + "if");
					if (!playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled)
						playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled = true;
				} else {
					playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().active = false;
					if (playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled)
						playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled = false;
					Debug.Log (playerFound.name + "else");
				}
			}
		} else if (Input.GetButtonDown ("2")) {
			Debug.Log ("Entro en el input");
			foreach (GameObject playerFound in players) {
				if (playerFound.name.Equals ("Digger")) {
					playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().active = true;
					actualPlayer = playerFound.transform.parent.gameObject;
					if (!playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled) {
						playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled = true;
					}
				} else {
					playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().active = false;
					if (playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled) {
						playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().move = 0;
						playerFound.transform.parent.gameObject.GetComponent<CharacterMovement> ().enabled = false;
					}
				}
			}
		}
	}	
}