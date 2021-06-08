using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{
    public Animator animator;

    bool facingRight = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject fantasminha = GameObject.Find("Fantasminha");
        Fantasma fantasma = fantasminha.GetComponent<Fantasma>();

        animator.SetFloat("Velocidade", Mathf.Abs(fantasma.translate));

        if (fantasma.translate < 0 && facingRight)
        {
            Flip();

        } else if (fantasma.translate > 0 && !facingRight) {

            Flip();
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
