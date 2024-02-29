using TMPro;
using UnityEngine;

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
        playersCount = scoreManager.NumberOfPlayers;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Private Methods

    #endregion
    #region Public Methods
    public void UpdateScore()
    {
        currentPlayer = scoreManager.currentPlayer;
        scoreTexts[currentPlayer].text = scoreManager.GetScore(currentPlayer).ToString();
    }
    #endregion
}
