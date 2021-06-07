using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject fantasminha = GameObject.Find("Fantasminha");
        Fantasma fantasma = fantasminha.GetComponent<Fantasma>();

        animator.SetFloat("Velocidade", Mathf.Abs(fantasma.translate));
    }
}
