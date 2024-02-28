using UnityEngine;
using TMPro;

public class OptionButton : MonoBehaviour
{
    public TextMeshProUGUI optionText;
    public GameController gameController; // Referencia al controlador de juego
    private int optionIndex; // Índice de la opción asociado a este botón

    #region Public Methods
    // Método llamado cuando se hace clic en el botón
    public void OnButtonClick()
    {
        // Comprobar si la opción seleccionada es la correcta
        bool isCorrect = gameController.CheckAnswer(optionIndex);

        // Manejar la interacción del jugador según si la respuesta es correcta o no
        if (isCorrect)
        {
            Debug.Log("¡Respuesta correcta!");
            // Aquí puedes realizar acciones adicionales para indicar que la respuesta es correcta
        }
        else
        {
            Debug.Log("Respuesta incorrecta.");
            // Aquí puedes realizar acciones adicionales para indicar que la respuesta es incorrecta
        }
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
        // Esto puede depender de cómo estén configurados tus botones de respuesta
        int index = ind;// Obtén el índice de la opción seleccionada;

        // Llama al método del ControladorJuego pasando el índice de la opción seleccionada
        gameController.SelectAnswer(index);
    }
#endregion
}