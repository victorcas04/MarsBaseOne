using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	public GUIText timeText;
	public float velocidadTiempo;

	void Start(){
		timeText.text = "Time (days) : 0";
	}

	void Update(){
		PreMenu.timeTot += velocidadTiempo * Time.deltaTime;
		timeText.text = "Time (days) : " + ((int)PreMenu.timeTot).ToString ();
	}
}
