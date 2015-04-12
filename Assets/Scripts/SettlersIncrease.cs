using UnityEngine;
using System.Collections;

public class SettlersIncrease : MonoBehaviour {

	public GUIText settlersText;

	void Start(){
		PreMenu.settlersMax = 3;
		PreMenu.settlers = 3;
		settlersText.text = PreMenu.settlers.ToString() + "/" + PreMenu.settlersMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.settlers < PreMenu.settlersMax) {
			PreMenu.settlers++;
		}
		settlersText.text = PreMenu.settlers.ToString() + "/" + PreMenu.settlers.ToString();
	}
}
