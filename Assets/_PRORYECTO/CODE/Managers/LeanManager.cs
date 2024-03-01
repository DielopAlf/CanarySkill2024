using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeanManager : MonoBehaviour
{
    private static LeanManager instance;
    public static LeanManager Instance { get { return instance; } }
    [SerializeField] private GameObject tapText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void TapTexAnimation()
    {
        LeanTween.scale(tapText, Vector3.one * 0.90f, 0.0f);
        LeanTween.scale(tapText, Vector3.one * 0.8f, 0.85f).setEaseInOutQuint().setLoopPingPong();
    }
}
