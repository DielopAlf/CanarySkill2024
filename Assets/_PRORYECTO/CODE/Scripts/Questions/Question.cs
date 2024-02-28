using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : IQuestion
{
    public string question { get; private set; }
    public string[] options { get; private set; }
    public int correctOption { get; private set; }
    
    public Question(string question, string[] options, int correctOption)
    {
        this.question = question;
        this.options = options;
        this.correctOption = correctOption;
    }
}
