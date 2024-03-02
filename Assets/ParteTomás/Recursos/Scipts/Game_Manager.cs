using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{

    private static Game_Manager instance;
    public static Game_Manager Instance { get { return instance; } }

    public float timerEnd = 10;
    public float timerStart = 3;
    public float delayInput = 1;
    public float end, start, delay;
    bool startdelay = false;

    //public bool tiempoTerminado;

    [SerializeField]
    GameObject canvas;
    /*[SerializeField]
    GameObject cartaRespuestaCopia, cartaPreguntaCopia, cartaRespuesta, cartaPregunta;*/

    private void Start()
    {
        //Variables ajustables desde el editor para el temporizador y delay antes de la siguiente ronda:
        end = timerEnd; start = timerStart; delay = delayInput; 
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
        //Temporizador básico para la partida:
        //Debug.Log(end);
        if (end > 0)
        {
            end -= Time.deltaTime;
        }
        //Al finalizar el temporizador, empieza a contar el temporizador del delay:
        if (end <= 0 || start != timerStart) 
        {
            start -= Time.deltaTime;
            canvas.SetActive(false);
            Test.Instance.Animation();
            //tiempoTerminado = true;
        }
        //Al acabar el delay, comienza la siguiente ronda:
        if (start <= 0)
        {
            Test.Instance.ShowNewQuestion();
            //tiempoTerminado = false;
            end = timerEnd;
            start = timerStart;
            startdelay = true;
            //GameController.Instance.ShowNewQuestion();
        }
        if (startdelay == true)
        {
            delay -= Time.deltaTime;
        }
        if (delay <= 0)
        {
            startdelay = false;
            delay = delayInput;
            canvas.SetActive(true);
        }
    }
}
