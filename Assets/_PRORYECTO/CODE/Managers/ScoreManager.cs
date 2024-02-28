using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region Private Fields
    [SerializeField] private int[] scores;
    #endregion
    #region Public Fields
    public int currentPlayer = 0;
    #endregion
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Public Methods
    public void IncorrectAnswer(int index, int amount)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[index] == i)
            {
                scores[i] -= amount;
            }
        }
    }
    public int GetScore(int index)
    {
        int score = 0;
        score = scores[index];
        return score;
    }
    #endregion
}
