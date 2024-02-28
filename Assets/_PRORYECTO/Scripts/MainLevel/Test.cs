using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    private static Test instance;
    public static Test Instance { get { return instance; } }

    #region Private Fields
    private int randomCategory;
    [SerializeField] private QuestionsCategories category;
    private string categoryStr;
    [SerializeField] private GameObject questionText;
    [SerializeField] private GameObject[] optionsText;
    [SerializeField] private QuestionManager questionManager;
    [SerializeField] private QuestionBase currentQuestion;

    public bool newQuestion;
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
    #region Public Methods
    public void ShowNewQuestion()
    {
        QuestionsCategories cat = (QuestionsCategories)(Random.Range(0, 5));
        currentQuestion = questionManager.GetRandomQuestion(cat.ToString());
        category = currentQuestion.questionCategory;
        categoryStr = category.ToString();

        if (currentQuestion == null)
        {
            Debug.LogError("No se Ppudo obtener una pregunta.");
            return;
        }

        questionText.GetComponent<TextMeshPro>().text = currentQuestion.statementQuestion;
        for (int i = 0; i < currentQuestion.options.Length; i++)
        {
            optionsText[i].GetComponent<TextMeshPro>().text = currentQuestion.options[i].ToString();
        }
    }
    public void Animation()
    {
        StartCoroutine(delayAfterRound());
        IEnumerator delayAfterRound()
        {
            newQuestion = true;
            yield return new WaitForSeconds(1.5f);
            newQuestion = false;
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

        Animation();
        //Mostrar nueva Pregunta
        ShowNewQuestion();
    }
    #endregion
}
