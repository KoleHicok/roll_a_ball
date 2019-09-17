using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoleQuitGame : MonoBehaviour
{
    public void doQuitGame()
    {
        Debug.Log ("Exiting game.");
        Application.Quit();
    }
}
