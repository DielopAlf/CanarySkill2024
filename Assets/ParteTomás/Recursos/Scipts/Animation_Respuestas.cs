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
    //Nada mas empezar, se inicia la animación de entrada de las cartas
    private void Awake()
    {
        animator.Play("CartaRespuestaEntrada");
    }
    //Cuando el booleano sea true, se inicia la animación de retirada de las cartas y comienza el temporizador del delay-
    //Cuando el booleano sea false, se inicia devuelta la animación de entrada de las cartas (siguiente ronda):
    private void Update()
    { 
        animator.SetBool("Terminado", Test.Instance.newQuestion);
    }
}
