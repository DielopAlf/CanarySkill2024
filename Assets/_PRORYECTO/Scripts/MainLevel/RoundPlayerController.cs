using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundPlayerController : MonoBehaviour
{
    public static RoundPlayerController instance;

    [SerializeField]
    private GameObject[] escores;
    //Gameplay por turnos:
    int currentplayerIndex = 1;
    int playersPlaying;
    int rondas = 1;
    public int maxrounds = 20;
    //Debug rondas y jugador en texto
    [SerializeField]
    TextMeshProUGUI ronda, jugador;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        escores = new GameObject[PlayerPrefs.GetInt("jugadores")];
        if (PlayerPrefs.GetInt("jugadores") == 1)
        {
            escores[0] = new GameObject("PlayerSlot");
        }
        if (PlayerPrefs.GetInt("jugadores") == 1)
        {
            escores[1] = new GameObject("PlayerSlot (1)");
        }
        if (PlayerPrefs.GetInt("jugadores") == 1)
        {
            escores[2] = new GameObject("PlayerSlot (2)");
        }
        if (PlayerPrefs.GetInt("jugadores") == 1)
        {
            escores[3] = new GameObject("PlayerSlot (3)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        ronda.text = "Ronda: " + rondas;
        jugador.text = "Jugador: " + currentplayerIndex;
        if (rondas > maxrounds)
        {
            Debug.Log("Se termina la partida");
        }
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
