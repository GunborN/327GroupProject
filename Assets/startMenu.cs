using UnityEngine;
using System.Collections;

public class startMenu : MonoBehaviour {
	public GameObject startMenuFirst;
	public GameObject Start_pressed_menu;
	public GameObject Game_Info_Menu;
	public GameObject Instructions_Menu;

	void Start_Pressed(){
		startMenuFirst.SetActive(false);
		Start_pressed_menu.SetActive(true);
	}
	void Back_From_Start_Pressed(){
		startMenuFirst.SetActive(true);
		Start_pressed_menu.SetActive(false);
	}
	void Info_Pressed(){
		startMenuFirst.SetActive(false);
		Game_Info_Menu.SetActive(true);
	}
	void Back_From_Info_Pressed(){
		startMenuFirst.SetActive(true);
		Game_Info_Menu.SetActive(false);
	}
	void Quit_Pressed(){
		Application.Quit ();
	}
}
