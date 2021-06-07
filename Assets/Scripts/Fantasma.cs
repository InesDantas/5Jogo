using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;

    private Rigidbody fantasma;

    [SerializeField]
    bool fantasmaSaltou = false;

    [SerializeField]
    float salto = 5;

    public float translate;

    void Start()
    {
        fantasma = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        translate = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, translate);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(fantasma.velocity.y) < 0.005f)
        {
            fantasma.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);

            fantasmaSaltou = true;
        }
    }

    void Rodar()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }
}
