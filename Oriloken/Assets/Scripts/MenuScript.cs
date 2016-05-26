using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 200, 300, 250), "Меню");
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 50), "Играть"))
        {
            Application.LoadLevel("Menu_play");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 50), "Выход"))
        {
            Application.Quit();
        }
    }
}
