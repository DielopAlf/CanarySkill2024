using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance { get { return instance; } }

    #region Private Fields
    private int randomCategory;
    [SerializeField] private QuestionsCategories category;
    private string categoryStr;
    [SerializeField] private GameObject questionText;
    [SerializeField] private GameObject[] optionsText;
    [SerializeField] private Button[] optionsButtons;
    [SerializeField]private QuestionManager questionManager;
    [SerializeField]private QuestionBase currentQuestion;
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
        
    }
    #endregion
    #region Private MEthods
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

        if (currentQuestion == null)
        {
            Debug.LogError("No se pudo obtener una pregunta.");
            return;
        }
        // Guarda el índice de la respuesta correcta
        int correctAnswerIndex = currentQuestion.correctAnswer;

        // Barajamos las opciones de respuesta
        ShuffleOptions(currentQuestion.options);

        // Muestra la pregunta y las opciones en la interfaz de usuario
        questionText.GetComponent<TextMeshPro>().text = currentQuestion.statementQuestion;

        for (int i = 0; i < currentQuestion.options.Length; i++)
        {
            optionsText[i].GetComponent<TextMeshPro>().text = currentQuestion.options[i].ToString();

            // Identificamos la respuesta correcta y marca el botón correspondiente
            if (i == correctAnswerIndex)
            {
                // Marca el botón de la respuesta correcta (opcional)
                optionsButtons[i].GetComponent<OptionButton>().SetupOption(currentQuestion.options[i].ToString(), i);
            }
            else
            {
                // Puedes realizar otras acciones para indicar que esta no es la respuesta correcta
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
        }
        else
        {
            Debug.Log("La respuesta correcta era: " + currentQuestion.options[currentQuestion.correctAnswer]);
            //Logica adicional a la respuesta incorrecta
            //como activar un sistema de pariculas
            //un sonito, etc
        }
        
        //Mostrar nueva Pregunta
        ShowNewQuestion();
    }
    #endregion
}
