using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void doQuitGame()
    {
        Debug.Log ("Exiting game.");
        Application.Quit();
    }
}
