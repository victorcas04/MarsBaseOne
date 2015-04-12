using UnityEngine;
using System.Collections;

public class FoodIncrease : MonoBehaviour {

	public GUIText foodText;

	void Start(){
		PreMenu.foodMax = 100;
		foodText.text = PreMenu.food.ToString () + "/" + PreMenu.foodMax.ToString();
	}

	void OnMouseDown(){
		if (PreMenu.food < PreMenu.foodMax) {
			PreMenu.food++;
		}
		foodText.text = PreMenu.food.ToString() + "/" + PreMenu.foodMax.ToString();
	}
}
