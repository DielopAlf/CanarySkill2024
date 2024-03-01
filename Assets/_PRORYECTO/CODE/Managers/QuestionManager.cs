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
        LoadQuestions();
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Private Methods
    private void LoadQuestions()
    {
        if (questions == null)
        {
            questions = new List<QuestionBase>();

            string[] folders = new string[] { "Arte_Literatura", "Ciencia_Naturaleza",
            "Deportes_Ocio", "Entretenimiento", "Geografía", "Historia", "Preguntas_Falsas" };

            foreach (var folder in folders)
            {
                QuestionBase[] questionCategory = Resources.LoadAll<QuestionBase>(folder);//Nombre de la carpeta
                questions.AddRange(questionCategory);
            }
        }
    }
    #endregion
    #region Public Methods
    public QuestionBase GetRandomQuestion()
    {        
        QuestionBase questionToReturn;

        if (questions == null || questions.Count == 0)
        {
            Debug.LogWarning("No hay preguntas disponibles.");
            return null;
        }

        int index = Random.Range(0, questions.Count);
        questionToReturn = questions[index];
        return questionToReturn;
    }
    #endregion
}
