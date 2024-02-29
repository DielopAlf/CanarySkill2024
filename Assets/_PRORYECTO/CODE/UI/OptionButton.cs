using UnityEngine;
using TMPro;

public class OptionButton : MonoBehaviour
{
    #region Private Fields
    private int optionIndex; // Índice de la opción asociado a este botón
    #endregion
    #region Public Fields
    public TextMeshProUGUI optionText;
    public GameController gameController; // Referencia al controlador de juego
    #endregion
    #region Public Methods
    // Método llamado cuando se hace clic en el botón
    public void OnButtonClick()
    {
        // Comprobar si la opción seleccionada es la correcta
        bool isCorrect = gameController.CheckAnswer(optionIndex);
        SelectAnswer(optionIndex);
    }

    // Método para configurar el texto de la opción y su índice asociado
    public void SetupOption(string text, int index)
    {
        optionText.text = text;
        optionIndex = index;
    }
    public void SelectAnswer(int ind)
    {
        // Aquí obtienes el índice de la opción seleccionada
        int index = ind;// Obtén el índice de la opción seleccionada;

        // Llama al método delGameController pasando el índice de la opción seleccionada
        gameController.SelectAnswer(index);
    }
#endregion
}