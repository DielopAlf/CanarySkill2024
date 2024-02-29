using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundColorRotate : MonoBehaviour
{
    public Color[] colors;
    public float rotationSpeed = 1.0f;

    public Image background;
    public int currentColorIndex = 0;

    void Start()
    {
        background = GetComponent<Image>();
        InvokeRepeating("CambiarColor", 0f, rotationSpeed);
    }

    void ColorChange()
    {
        if (colors.Length == 0)
        {
            Debug.LogError("Añade al menos un color al arreglo.");
            return;
        }

        background.color = colors[currentColorIndex];
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
    }
}
