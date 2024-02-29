using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundPlayerController : MonoBehaviour
{
    //Gameplay por turnos:
    int currentplayerIndex = 1;
    int playersPlaying;
    int rondas = 1;
    //Debug rondas y jugador en texto
    [SerializeField]
    TextMeshProUGUI ronda, jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ronda.text = "Ronda: " + rondas;
        jugador.text = "Jugador: " + currentplayerIndex;
    }

    public void RoundPlayerFunction()
    {
        if (currentplayerIndex != PlayerPrefs.GetInt("jugadores") + 1)
        {
            currentplayerIndex++;
        }
        else
        {
            currentplayerIndex = 1;
            rondas++;
        }
    }
}
