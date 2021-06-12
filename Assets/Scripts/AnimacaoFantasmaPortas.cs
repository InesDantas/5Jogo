using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoFantasmaPortas : MonoBehaviour
{
    public Animator animator;

    bool facingRight = true;

    void Start()
    {
        
    }

    void Update()
    {
        GameObject fantasminhaPortas = GameObject.Find("FantasminhaPortas");
        FantasmaPortas fantasmaPortas = fantasminhaPortas.GetComponent<FantasmaPortas>();

        animator.SetFloat("Velocidade", Mathf.Abs(fantasmaPortas.translate));

        if (fantasmaPortas.translate > 0 && facingRight)
        {
            Flip();

        }
        else if (fantasmaPortas.translate < 0 && !facingRight)
        {

            Flip();
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
