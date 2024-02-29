using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsFunctions : MonoBehaviour
{
    public GameObject creditsScreen, playerSelectScreen;

    public void SelectPlayers()
    {
        playerSelectScreen.SetActive(true);
    }

    public void ClosePlayerSelectScreen()
    {
        playerSelectScreen.SetActive(false);
    }

    public void StartCredits()
    {
        creditsScreen.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Se sale del juego");
        Application.Quit();
    }
}
