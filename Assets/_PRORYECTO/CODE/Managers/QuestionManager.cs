using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour, IQuestionManager
{
    #region Public Fields
    public List<Question> questions {  get; private set; }
    #endregion
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        //Inicializador de preguntas, se pueden agregar mas preguntas desde un archivo o base de datos.
        questions = new List<Question>();

        new Question("En qué isla nos encontramos?", new string[] { "Madriz", "Mallorca", "Gran Canarias", "Tenerife" }, 4);

        // Agregar más preguntas
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Public Methods
    public IQuestion GetQuestion()
    {
        int index = Random.Range(0, questions.Count);
        return questions[index];
    }
    #endregion
}
