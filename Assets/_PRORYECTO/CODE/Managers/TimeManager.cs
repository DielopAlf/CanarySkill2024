using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    #region Instance
    private static TimeManager instance;
    public static TimeManager Instance { get { return instance; } }
    #endregion
    #region Private Field
    [Header("GameController")]
    [SerializeField]private GameController gameController;
    [SerializeField] private float initTime;
    [SerializeField] private float currentTime;
    [SerializeField] private bool countdownActive = false;
    #endregion
    #region Public Fields
    public float CurrentTime { get { return currentTime; } }
    #endregion
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownActive)
        {
            //Iniciamos la cuenta atras
            currentTime -= Time.deltaTime;

            if (currentTime <= 0.0f)
            {
                //Retornamos la activacion de la cuenta atras a false
                countdownActive = false;
                //Descontamos un punto
                ScoreManager.Instance.TimeOut(ScoreManager.Instance.currentPlayer);
                //Mostraremos una nueva pregunta para el siguiente jugador
                gameController.ShowNewQuestion();
            }

            /*if (currentTime <= 5.0f)
            {
                LeanManager.Instance.TimerTextAnimation();
            }*/
        }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion
    #region Public Methods
    public void StartCountdown()
    {
        currentTime = initTime;
        countdownActive = true;
    }
    #endregion
}
