using UnityEngine;
using System.Collections;

public class PreMenu : MonoBehaviour {

	public static float timeTot;
	public static bool showMenu;
	public static int food;
	public static int foodMax;
	public static int water;
	public static int waterMax;
	public static int iron;
	public static int ironMax;
	public static int copper;
	public static int copperMax;
	public static int hydrogen;
	public static int hydrogenMax;
	public static int oxygen;
	public static int oxygenMax;
	public static int settlers;
	public static int settlersMax;

	void Start () {
		timeTot = 0;
		showMenu = false;
		food = 0;
		foodMax = 100;
		water = 0;
		waterMax = 100;
		iron = 0;
		ironMax = 150;
		copper = 0;
		copperMax = 150;
		hydrogen = 0;
		hydrogenMax = 250;
		oxygen = 0;
		oxygenMax = 250;
		settlers = 3;
		settlersMax = 0;
		Application.LoadLevel ("Intro");
	}
}
