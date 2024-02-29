using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_controller : MonoBehaviour
{


    public AudioSource audioSource;
    public AudioClip respuestacorrecta;
    public AudioClip respuestaincorrecta;

    void Start()
    {

    }

    public void PlaySound(AudioClip clip)
    {

        audioSource.Play();
    }
}