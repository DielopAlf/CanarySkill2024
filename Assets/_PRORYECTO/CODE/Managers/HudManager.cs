using System.Collections;
using TMPro;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    #region Instance
    private static HudManager instance;
    public static HudManager Instance { get { return instance; } }
    #endregion
    #region Private Field
    [Header("Managers")]
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TimeManager timeManager;

    [Space(5)]
    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI[] scoreTexts;
    [SerializeField] private TextMeshProUGUI timeTextShadow;
    [SerializeField] private TextMeshProUGUI timeText;

    [Space(5)]
    [Header("Rounds-Turns")]
    [SerializeField] private GameObject roundGo;
    [SerializeField] private GameObject turnGo;
    [SerializeField] private TextMeshProUGUI roundTextShadow;
    [SerializeField] private TextMeshProUGUI roundText;
    [SerializeField] private TextMeshProUGUI turnTextShadow;
    [SerializeField] private TextMeshProUGUI turnText;
    #endregion
    #region Public Field
    public GameObject RoundGo { get { return roundGo; } }
    public GameObject TurnGo { get { return turnGo; } }
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
        timeTextShadow.text = timeManager.CurrentTime.ToString("F0");
        timeText.text = timeManager.CurrentTime.ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion
    #region Private Methods
    private void UpdateTimer()
    {
        timeTextShadow.text = timeManager.CurrentTime.ToString("F0");
        timeText.text = timeManager.CurrentTime.ToString("F0");

        if (timeManager.CurrentTime < 10.0f)
        {
            timeTextShadow.text = timeManager.CurrentTime.ToString("F0").PadLeft(1, '0');
            timeText.text = timeManager.CurrentTime.ToString("F0").PadLeft(1, '0');
        }
    }
    #endregion
    #region Public Methods
    public void UpdateScore()
    {
        currentPlayer = scoreManager.currentPlayer;
        scoreTexts[currentPlayer].text = scoreManager.GetScore(currentPlayer).ToString();
        scoreTexts[currentPlayer + 1].text = scoreManager.GetScore(currentPlayer).ToString();
    }
    public void UpdateRoundText(int round)
    {
        roundTextShadow.text = "Round " + round.ToString();
        roundText.text = "Round " + round.ToString();
    }
    public void UpdateTurnText(int curTurnPlayer)
    {
        turnTextShadow.text = "Turn Player " + curTurnPlayer.ToString();
        turnText.text = "Turn Player " + curTurnPlayer.ToString();
    }

    public void ActiveGameObject(GameObject go)
    {
        go.SetActive(true);
    }
    public void DesactiveGameObject(GameObject go)
    {
        go.SetActive(false);
    }
    #endregion
}
