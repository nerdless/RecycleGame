using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour {

    public Canvas menu;

    public void starGame(){
        menu.enabled = false;
    }

    public void reloadGame()
    {
        Application.LoadLevel(0);
    }

}
