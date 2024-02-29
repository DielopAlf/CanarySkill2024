using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlayers : MonoBehaviour
{
    public void Select1Player()
    {
        Debug.Log("Partida para 1 jugador");
        PlayerPrefs.SetInt("jugadores", 1);
    }
    public void Select2Player()
    {
        Debug.Log("Partida para 2 jugadores");
        PlayerPrefs.SetInt("jugadores", 2);
    }
    public void Select3Player()
    {
        Debug.Log("Partida para 3 jugadores");
        PlayerPrefs.SetInt("jugadores", 3);
    }
    public void Select4Player()
    {
        Debug.Log("Partida para 4 jugadores");
        PlayerPrefs.SetInt("jugadores", 4);
    }

    // Función para cargar directamente el juego, saltando la pantalla de selección de número de 
    // jugadores
    public void DirectLoad()
    {
        SceneManager.LoadScene("MechanicsScenes_Custom");
    }
}
