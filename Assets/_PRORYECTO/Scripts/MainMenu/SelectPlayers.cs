using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPlayers : MonoBehaviour
{
    public void Select1Player()
    {
        Debug.Log("Partida para 1 jugador");
    }
    public void Select2Player()
    {
        Debug.Log("Partida para 2 jugadores");
    }
    public void Select3Player()
    {
        Debug.Log("Partida para 3 jugadores");
    }
    public void Select4Player()
    {
        Debug.Log("Partida para 4 jugadores");
    }

    // Funci�n para cargar directamente el juego, saltando la pantalla de selecci�n de n�mero de 
    // jugadores
    //public void DirectLoad()
    //{
    //    SceneManager.LoadScene("NOMBRE DE LA ESCENA");
    //}
}
