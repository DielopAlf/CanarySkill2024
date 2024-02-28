using UnityEngine;

public interface IQuestion
{
    string question { get; }
    string[] options { get; }
    int correctOption { get; }
}
