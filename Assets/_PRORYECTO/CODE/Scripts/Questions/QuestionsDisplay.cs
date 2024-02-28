using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestionsCategories
{
    GEOGRAFIA,
    ARTE_Y_LITERATURA,
    HISTORIA,
    CIENCIAS_Y_NATURALEZA,
    DEPORTE_Y_OCIO,
    ENTRETENIMIENTO,
    DEFAULT
}

public class QuestionsDisplay : MonoBehaviour
{
    #region Instance
    private static QuestionsDisplay instance;
    public static QuestionsDisplay Instance { get { return instance; } }
    #endregion
    #region Categories
    public QuestionsCategories questionCategory;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
