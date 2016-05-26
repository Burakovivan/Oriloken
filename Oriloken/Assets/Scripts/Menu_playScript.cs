using UnityEngine;
using System.Collections;

public class Menu_playScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 200, 300, 450), "Меню");
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 50), "Уровень 1"))
        {
            Application.LoadLevel("Level1");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2  - 50, 200, 50), "Уровень 2"))
        {
            Application.LoadLevel("Level2");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 50), "Уровень 3"))
        {
            Application.LoadLevel("Level3");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 150, 200, 50), "Назад"))
        {
            Application.LoadLevel("Main_menu");
        }
    }
}
