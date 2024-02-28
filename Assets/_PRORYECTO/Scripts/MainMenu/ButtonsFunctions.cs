using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsFunctions : MonoBehaviour
{
    public GameObject creditsScreen, playerSelectScreen;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SelectPlayers()
    {
        Debug.Log("Selecciona el número de jugadores");
        playerSelectScreen.SetActive(true);
    }

    public void ClosePlayerSelectScreen()
    {
        playerSelectScreen.SetActive(false);
    }

    public void StartCredits()
    {
        Debug.Log("Se inician los créditos");
        creditsScreen.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Se sale del juego");
        Application.Quit();
    }
}
