using UnityEngine;
using System.Collections;

public class PreMenu : MonoBehaviour {

	public static float timeTot;
	public static bool showMenu;
	public static int food;
	public static int water;
	public static int metal;
	public static int gas;
	public static int population;

	// Use this for initialization
	void Start () {
		timeTot = 0;
		showMenu = false;
		food = 0;
		water = 0;
		metal = 0;
		gas = 0;
		population = 0;
		Application.LoadLevel ("Menu");
	}
}
