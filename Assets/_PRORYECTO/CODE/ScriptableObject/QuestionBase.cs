using UnityEngine;

public enum QuestionsCategories
{
    GEOGRAFIA,
    ARTE_Y_LITERATURA,
    HISTORIA,
    CIENCIAS_Y_NATURALEZA,
    DEPORTE_Y_OCIO,
    ENTRETENIMIENTO,
    DE_VERDAD,
    DEFAULT
}

[CreateAssetMenu(fileName = "New Question", menuName = "Question/New Question")]
public class QuestionBase : ScriptableObject
{
    public QuestionsCategories questionCategory;
    public Question question;
    public Color categoryColor;
    public string statementQuestion;
    public string[] options;
    public int correctAnswer;
}
