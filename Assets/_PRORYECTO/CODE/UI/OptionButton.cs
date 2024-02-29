using UnityEngine;
using TMPro;

public class OptionButton : MonoBehaviour
{
    #region Private Fields
    private int optionIndex; // �ndice de la opci�n asociado a este bot�n
    #endregion
    #region Public Fields
    public TextMeshProUGUI optionText;
    public GameController gameController; // Referencia al controlador de juego
    #endregion
    #region Public Methods
    // M�todo llamado cuando se hace clic en el bot�n
    public void OnButtonClick()
    {
        // Comprobar si la opci�n seleccionada es la correcta
        bool isCorrect = gameController.CheckAnswer(optionIndex);
        SelectAnswer(optionIndex);
    }

    // M�todo para configurar el texto de la opci�n y su �ndice asociado
    public void SetupOption(string text, int index)
    {
        optionText.text = text;
        optionIndex = index;
    }
    public void SelectAnswer(int ind)
    {
        // Aqu� obtienes el �ndice de la opci�n seleccionada
        int index = ind;// Obt�n el �ndice de la opci�n seleccionada;

        // Llama al m�todo delGameController pasando el �ndice de la opci�n seleccionada
        gameController.SelectAnswer(index);
    }
#endregion
}