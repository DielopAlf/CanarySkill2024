using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Static
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    #endregion
    #region Private Fields
    [Header("Managers")]
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TimeManager timeManager;
    [SerializeField] private LeanManager leanManager;
    [SerializeField]private HudManager hudManager;

    [Space(5)]
    [Header("Players")]
    [SerializeField] private int numberOfPlayers;

    [Space(5)]
    [Header("Rounds and Turns")]
    [SerializeField] private int totalRounds = 10;
    [SerializeField] private int currentRound = 1;
    [SerializeField] private int currentPlayerIndex = 0;
    private int turnsPerRound;
    #endregion
    #region Public Fields
    public int CurrentRound { get { return currentRound; } }
    public int CurrentPlayerIndex { get { return currentPlayerIndex; } }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        //Calculamos el numero de turnos por ronda basado en el numero de jugadores
        turnsPerRound = Mathf.Clamp(numberOfPlayers, 1, 4);
        //StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #region Private Methods
    private void StartRound()
    {
        hudManager.UpdateRoundText(currentRound);
        StartTurn();        
    }
    private void StartTurn()
    {
        // Aquí podremos mostrar la pregunta y esperar la respuesta del jugador actual
        // Una vez que se responda la pregunta, llamar a EndTurn()
        hudManager.UpdateTurnText(currentPlayerIndex);
        GameController.Instance.ShowNewQuestion();
    }
    private void EndTurn()
    {
        //Pasaremos al siguiente jugador
        currentPlayerIndex = (currentPlayerIndex + 1) % numberOfPlayers;

        //Si todos los jugadores han jugado, pasaremos a la siguiente ronda
        if (currentPlayerIndex == 0)
        {
            currentRound++;

            //Comprobamos si el juego ha terminado
            if (currentRound > totalRounds)
            {
                EndGame();
                return;
            }
        }

        //Iniciaremos el turno del proximo jugador
        StartTurn();
    }
    private void EndGame()
    {
        //Mostrar el marcador final, posibilidad de reiniciar partidaa o volver al menu principal
        Debug.Log("Fin del juego");
    }
    #endregion
    #region Public Methods
    public void StartGame()
    {
        //Inicializamos el tiempo
        timeManager.StartCountdown();

        //Inicializamos la ronda y el turno
        currentRound = 1;
        currentPlayerIndex = 0;

        //Iniciamos la ronda
        StartRound();
    }
    #endregion
}
