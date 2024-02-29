using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

public class GameController : MonoBehaviour
{
    #region Instance
    private static GameController instance;
    public static GameController Instance { get { return instance; } }
    #endregion
    #region Private Fields
    private int randomCategory;
    [SerializeField] private QuestionsCategories category;
    private string categoryStr;
    [SerializeField] private GameObject questionText;
    [SerializeField] private GameObject[] optionsText;
    [SerializeField] private Button[] optionsButtons;
    [SerializeField] private GameObject[] letters;
    [SerializeField] private ProceduralImage[] lettersOptBg;
    [SerializeField]private QuestionManager questionManager;
    [SerializeField]private QuestionBase currentQuestion;
    [Space(5)]
    [Header("Colors")]
    [SerializeField] private Color failColor;
    [SerializeField] private Color successColor;
    [SerializeField] private Color textColor;
    #endregion
    #region Public Field
    public Button[] OptionsButtons { get { return optionsButtons; } }
    public bool CheckAnswer(int index)
    {
        if (currentQuestion == null)
        {
            Debug.LogError("No hay pregunta actual para comprobar la respuesta.");
            return false;
        }

        //Obetenemos el index de la opcion correcta
        int indexCorrectAnswer = currentQuestion.correctAnswer;

        //Comprobamos si la opcion seleccionada es la correcta
        bool isCorrect = (index == indexCorrectAnswer);
        return isCorrect;
    }
    public string testInt;
    #endregion
    #region Unity Methods
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        questionManager = GetComponent<QuestionManager>();
        
        ShowNewQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(testInt);
    }
    #endregion
    #region Private Methods
    private void ShuffleOptions(string[] options)
    {
        // Baraja el arreglo de opciones usando el algoritmo de Fisher-Yates
        for (int i = 0; i < options.Length; i++)
        {
            int randomIndex = Random.Range(i, options.Length);
            string temp = options[randomIndex];
            options[randomIndex] = options[i];
            options[i] = temp;
        }
    }
    #endregion
    #region Public Methods   
    public void ShowNewQuestion()
    {
        currentQuestion = questionManager.GetRandomQuestion();
        testInt = currentQuestion.options[currentQuestion.correctAnswer];
        Debug.Log(testInt);

        if (currentQuestion == null)
        {
            Debug.LogError("No se pudo obtener una pregunta.");
            return;
        }

        Debug.Log("El tamaño de las respuesta es de: " + currentQuestion.options.Length);

        // Guarda el índice de la respuesta correcta
        int correctAnswerIndex = currentQuestion.correctAnswer;

        // Barajamos las opciones de respuesta
        ShuffleOptions(currentQuestion.options);

        // Muestra la pregunta y las opciones en la interfaz de usuario
        questionText.GetComponent<TextMeshProUGUI>().text = currentQuestion.statementQuestion;  //Salida "Null Reference"
        questionText.GetComponent<TextMeshProUGUI>().color = currentQuestion.categoryColor;

        for (int i = 0; i < currentQuestion.options.Length; i++)
        {
            optionsText[i].GetComponent<TextMeshProUGUI>().text = currentQuestion.options[i].ToString();
            optionsText[i].GetComponent<TextMeshProUGUI>().color = currentQuestion.categoryColor;
            letters[i].GetComponent<TextMeshProUGUI>().color = textColor;
            lettersOptBg[i].color = currentQuestion.categoryColor;

            // Identificamos la respuesta correcta y marca el botón correspondiente
            if (i == correctAnswerIndex)
            {
                // Marca el botón de la respuesta correcta (opcional)
                optionsButtons[i].GetComponent<OptionButton>().SetupOption(currentQuestion.options[i].ToString(), i);

                //Refuerzo visual y sonoro de acierto,
                //como pueden ser sistemas de particulas, sonidos o animaciones
            }
            else
            {
                // Puedes realizar otras acciones para indicar que esta no es la respuesta correcta
                //como sistemas de particulas, sonidos o animaciones
            }
        }
    }
    public void SelectAnswer(int index)
    {
        if (currentQuestion == null)
        {
            Debug.LogError("No hay pregunta actual.");
            return;
        }

        if (index == currentQuestion.correctAnswer)
        {
            Debug.Log("Respuesta Correcta!");
            //Logica adicional a la respuesta correcta
            //como activar un sistema de pariculas
            //un sonito, etc
            optionsButtons[index].GetComponent<ProceduralImage>().color = successColor;
            optionsButtons[index].GetComponentInChildren<TextMeshProUGUI>().color = textColor;
        }
        else if(index != currentQuestion.correctAnswer)
        {
            Debug.Log("La respuesta correcta era: " + currentQuestion.options[currentQuestion.correctAnswer]);
            //Logica adicional a la respuesta incorrecta
            //como activar un sistema de pariculas
            //un sonito, etc
            optionsButtons[index].GetComponent<ProceduralImage>().color = failColor;
            optionsButtons[index].GetComponentInChildren<TextMeshProUGUI>().color = textColor;
        }
        
        //Mostrar nueva Pregunta
        ShowNewQuestion();
    }
    #endregion
}
