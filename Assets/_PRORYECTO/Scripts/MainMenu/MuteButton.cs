using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public bool isClicked = false;
    public Image muteButton;
    public Sprite muteIcon, unmuteIcon;
    public AudioMixer audioMixer;

    private void Start()
    {
        isClicked = false;
        muteButton.GetComponent<Image>().sprite = unmuteIcon;
    }

    public void ButtonToggle()
    {
        if (isClicked)
        {
            isClicked = false;
            muteButton.GetComponent<Image>().sprite = unmuteIcon;
            audioMixer.SetFloat("MasterVolume", 0);
        }
        else
        {
            isClicked = true;
            muteButton.GetComponent<Image>().sprite = muteIcon;
            audioMixer.SetFloat("MasterVolume", -80);
        }
    }
}
