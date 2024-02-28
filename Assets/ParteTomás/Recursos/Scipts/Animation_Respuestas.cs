using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Respuestas : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    private void Awake()
    {
        animator.Play("CartaRespuestaEntrada");
    }
    private void Update()
    { 
        animator.SetBool("Terminado", GameManager.Instance.tiempoTerminado == true);
    }
}
