using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Private Fields
    private int randomCategory;
    [SerializeField] private QuestionsCategories category;
    private string categoryStr;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private TextMeshProUGUI[] optionsText;
    [SerializeField]private QuestionManager questionManager;
    [SerializeField]private QuestionBase currentQuestion;
    #endregion
    #region Unity Methods
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
    #region Public Methods
    public void ShowNewQuestion()
    {
        currentQuestion = questionManager.GetRandomQuestion(currentQuestion.questionCategory.ToString());
        category = currentQuestion.questionCategory;
        categoryStr = category.ToString();

        if (currentQuestion == null)
        {
            Debug.LogError("No se Ppudo obtener una pregunta.");
            return;
        }

        questionText.text = currentQuestion.question.ToString();
        for (int i = 0; i < currentQuestion.options.Length; i++)
        {
            optionsText[i].text = currentQuestion.options[i].ToString();
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
