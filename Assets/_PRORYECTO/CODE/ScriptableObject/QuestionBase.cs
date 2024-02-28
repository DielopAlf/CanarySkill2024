using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Question/New Question")]
public class QuestionBase : ScriptableObject
{
    public Question question;
    public string statementQuestion;
    public string[] options;
    public int correctAnswer;
}
