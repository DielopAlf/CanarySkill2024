using UnityEngine;
using TMPro;

public class OptionButton : MonoBehaviour
{
    public TextMeshProUGUI optionText;
    public GameController gameController; // Referencia al controlador de juego
    private int optionIndex; // �ndice de la opci�n asociado a este bot�n

    #region Public Methods
    // M�todo llamado cuando se hace clic en el bot�n
    public void OnButtonClick()
    {
        // Comprobar si la opci�n seleccionada es la correcta
        bool isCorrect = gameController.CheckAnswer(optionIndex);

        // Manejar la interacci�n del jugador seg�n si la respuesta es correcta o no
        if (isCorrect)
        {
            Debug.Log("�Respuesta correcta!");
            // Aqu� puedes realizar acciones adicionales para indicar que la respuesta es correcta
        }
        else
        {
            Debug.Log("Respuesta incorrecta.");
            // Aqu� puedes realizar acciones adicionales para indicar que la respuesta es incorrecta
        }
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
        // Esto puede depender de c�mo est�n configurados tus botones de respuesta
        int index = ind;// Obt�n el �ndice de la opci�n seleccionada;

        // Llama al m�todo del ControladorJuego pasando el �ndice de la opci�n seleccionada
        gameController.SelectAnswer(index);
    }
#endregion
}