using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScreen : MonoBehaviour
{
    public Transform endPointCredits;
    public GameObject creditsCanvas;
    private Vector3 initialPosition;
    public float scrollSpeed = 5f;

    private void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPointCredits.position, scrollSpeed * Time.deltaTime);

        if (transform.position == endPointCredits.position)
        {
            creditsCanvas.SetActive(false);
            transform.position = initialPosition;
        }
    }
}
