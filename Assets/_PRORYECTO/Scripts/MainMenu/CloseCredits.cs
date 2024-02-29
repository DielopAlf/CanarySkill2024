using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCredits : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
    }
}
