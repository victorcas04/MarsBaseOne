using UnityEngine;
using System.Collections;

public class BlockMenu : MonoBehaviour {

	float xPosition;
	float yPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		if (GameObject.Find ("Global").GetComponent<Global> ().showMenu == false) {

			GameObject.Find ("Global").GetComponent<Global> ().showMenu = true;
			GameObject.Find ("Global").GetComponent<Global> ().selectedBlock = gameObject;
		}
	}

	void OnGUI(){

		if(GameObject.Find ("Global").GetComponent<Global> ().showMenu == true){
			if(GUI.Button(new Rect(0,224,135,26),"Recolect")){

				Debug.Log(gameObject.name);
			}

			if(GUI.Button(new Rect(0,251,135,26),"Dig")){


				//Debug.Log(gameObject.name);
				GameObject.Destroy(GameObject.Find ("Global").GetComponent<Global> ().selectedBlock);
				GameObject.Find ("Global").GetComponent<Global> ().showMenu = false;
			}
		}
	}
}
