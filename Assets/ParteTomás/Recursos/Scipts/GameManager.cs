using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public float timerEnd = 10;
    public float timerStart = 3;
    float end, start;
    public bool rondaTerminada, tiempoTerminado;
    [SerializeField]
    GameObject canvas;
    /*[SerializeField]
    GameObject cartaRespuestaCopia, cartaPreguntaCopia, cartaRespuesta, cartaPregunta;*/

    private void Start()
    {
        end = timerEnd; start = timerStart;
        /*Instantiate(cartaPreguntaCopia);
        Instantiate(cartaRespuestaCopia);*/  
    }
        private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        Debug.Log(end);
        if (end > 0)
        {
            canvas.SetActive(true);
            end -= Time.deltaTime;
        }
        if (end <= 0) 
        {
            start -= Time.deltaTime;
            canvas.SetActive(false);
            tiempoTerminado = true;
        }
        if (start <= 0)
        {
            tiempoTerminado = false;
            end = timerEnd;
            start = timerStart;
        }
    }

}
