using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Preguntas : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    private void Awake()
    {
        animator.Play("CartaPreguntaEntrada");
    }
    private void Update()
    {
        animator.SetBool("Terminado", GameManager.Instance.tiempoTerminado == true);
    }
}
