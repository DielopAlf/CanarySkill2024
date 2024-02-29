using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorRotate : MonoBehaviour
{
    public Color[] colors;
    public float rotationSpeed = 1.0f;

    private Image cloud;
    public int currentColorIndex = 0;

    void Start()
    {
        cloud = GetComponent<Image>();
        InvokeRepeating("ColorChange", 0f, rotationSpeed);
    }

    void ColorChange()
    {
        cloud.color = colors[currentColorIndex];
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
    }
}
