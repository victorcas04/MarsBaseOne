using UnityEngine;
using System.Collections;

public class SettlersDecrease : MonoBehaviour {

	public GUIText settlersText;

	 void Start(){
		PreMenu.settlersMax = 3;
		PreMenu.settlers = 3;
	}

	void OnMouseDown(){
		if (PreMenu.settlers > 0) {
			PreMenu.settlers--;
		}
		settlersText.text = ((int)PreMenu.settlers).ToString() + "/" + PreMenu.settlersMax.ToString();
	}
}
