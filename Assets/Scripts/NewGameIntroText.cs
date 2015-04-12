using UnityEngine;
using System.Collections;

public class NewGameIntroText : MonoBehaviour {

	private float timeText;
	public GUIText text;
	public GUIText text1;
	public GUIText text2;
	public GUIText text3;
	public GUIText text4;
	public GUIText text5;

	// Use this for initialization
	void Start () {
		timeText = 0;
		text.enabled = false;
		text1.enabled = false;
		text2.enabled = false;
		text3.enabled = false;
		text4.enabled = false;
		text5.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeText < 2) {
			text.enabled = true;
		} else if (timeText < 5) {
			text1.enabled = true;
		} else if (timeText < 8) {
			text2.enabled = true;
		} else if (timeText < 11) {
			text.enabled = false;
			text1.enabled = false;
			text2.enabled = false;
			text3.enabled = true;
		} else if (timeText < 14) {
			text4.enabled = true;
		} else if (timeText < 17) {
			text3.enabled = false;
			text4.enabled = false;
			text5.enabled = true;
		} else if (timeText >= 20) {
			text5.enabled = false;
			Application.LoadLevel ("Levels");
		}
		timeText += Time.deltaTime;
	}
}
