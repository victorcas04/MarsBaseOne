using UnityEngine;
using System.Collections;

public class FoodDecrease : MonoBehaviour {

	public GUIText foodText;

	void Start(){
		PreMenu.foodMax = 100;
	}

	void OnMouseDown(){
		if (PreMenu.food > 0) {
			PreMenu.food--;
		}
		foodText.text = PreMenu.food.ToString() + "/" + PreMenu.foodMax.ToString();
	}
}
