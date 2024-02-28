using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Private Fields
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private TextMeshProUGUI[] optionsText;
    private IQuestionManager questionManager;
    private IQuestion currentQuestion;
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
        currentQuestion = questionManager.GetQuestion();

        questionText.text = currentQuestion.question;
        for (int i = 0; i < currentQuestion.options.Length; i++)
        {
            optionsText[i].text = currentQuestion.options[i];
        }
    }
    public void SelectAnswer(int index)
    {
        if (index == currentQuestion.correctOption)
        {
            Debug.Log("Respuesta Correcta!");
            //Logica adicional a la respuesta correcta
            //como activar un sistema de pariculas
            //un sonito, etc
        }
        else
        {
            Debug.Log("La respuesta correcta era: " + currentQuestion.options[currentQuestion.correctOption]);
            //Logica adicional a la respuesta incorrecta
            //como activar un sistema de pariculas
            //un sonito, etc
        }

        //Mostrar nueva Pregunta
        ShowNewQuestion();
    }
    #endregion
}
