using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5;

    private Rigidbody fantasma;

    [SerializeField]
    bool fantasmaSaltou = false;

    //[SerializeField]
    //float tempoDeEspera = 2f;

    //float tempoDecorrido = 0f;

    [SerializeField]
    float salto = 5;

    // Start is called before the first frame update
    void Start()
    {
        fantasma = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float translate = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, translate);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(fantasma.velocity.y) < 0.005f)
        {
            fantasma.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);

            fantasmaSaltou = true;
           //tempoDecorrido = 0;
        }

        /*if (fantasmaSaltou == true)
        {
            tempoDecorrido = Time.deltaTime;
            if (tempoDecorrido >= tempoDeEspera)
            {
                fantasmaSaltou = false;
            }
        }*/
    }

}
