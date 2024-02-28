using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    #region Public Fields
    //public List<QuestionBase> questions {  get;  set; }
    public List<QuestionBase> questions;
    #endregion
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        //Inicializador de preguntas, se pueden agregar mas preguntas desde un archivo o base de datos.
        //questions = new List<QuestionBase>(Resources.LoadAll<QuestionBase>("Questions"));

        //new Question("En qué isla nos encontramos?", new string[] { "Madriz", "Mallorca", "Gran Canarias", "Tenerife" }, 4);

        // Agregar más preguntas
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Public Methods
    public QuestionBase GetRandomQuestion(string category)
    {
        List<QuestionBase> questionInCategory = questions.FindAll(question => question.questionCategory.ToString() == category);
        if (questionInCategory.Count == 0)
        {
            Debug.LogWarning("No hay preguntas en la categoria " + category);
            return null;
        }

        int index = Random.Range(0, questionInCategory.Count);
        return questionInCategory[index];
    }
    #endregion
}
