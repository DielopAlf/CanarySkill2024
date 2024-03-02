using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region Instance
    private static ScoreManager instance;
    public static ScoreManager Instance { get { return instance; } }
    #endregion
    #region Private Fields
    [SerializeField] private HudManager hudManager;
    [SerializeField] private int numberOfPlayer;
    [SerializeField] private int[] scores;
    #endregion
    #region Public Fields
    public int currentPlayer = 0;
    public int NumberOfPlayers { get { return numberOfPlayer; } }
    #endregion
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlayer > numberOfPlayer - 1) { currentPlayer = 0; }
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
    public void IncorrectAnswer(int index)
    {
        int score = GetScore(index);

        scores[index]--;
        hudManager.UpdateScore();
    }
    public void TimeOut(int index)
    {
        int score = GetScore(index);

        scores[index]--;
        hudManager.UpdateScore();
    }
    public int GetScore(int index)
    {
        int score = 0;
        score = scores[index];
        return score;
    }
    #endregion
}
