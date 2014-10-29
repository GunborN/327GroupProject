using UnityEngine;
using System.Collections;

public class start_menu_click : MonoBehaviour {
	public GameObject Start_Menu;
	public GameObject choice_Menu;	
	void OnClick(){
		choice_Menu.SetActive (true);
		Start_Menu.SetActive (false);
	}
}
