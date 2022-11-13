using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class MainMenuEvents : MonoBehaviour
{
    public void NewGame()
    {
        AC.KickStarter.RestartGame(true, 3, true);
        Debug.Log("New Game");
    }

    public void LoadGame()
    {
        Debug.Log("LoadGame");
    }

    public void Options()
    {
        Debug.Log("Options");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
