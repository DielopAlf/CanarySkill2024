using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManager : MonoBehaviour
{
    #region Private Field
    [SerializeField] private ScoreManager scoreManager;
    #endregion
    #region Public Field
    [SerializeField] private TextMeshProUGUI[] scoreTexts;
    #endregion
    #region Public Methods
    public int playersCount = 1;   //Modificar dependiendo del numero de jugadores seleccionados
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
    #region Private Methods

    #endregion
    #region Public Methods
    public void UpdateScore(int index)
    {
        for (int i = 0; i < scoreTexts.Length; i++)
        {
            if (currentPlayer == i)
            {
                scoreTexts[index].text = scoreManager.GetScore(index).ToString().PadLeft(3, '0');
            }
        }
    }
    #endregion
}
