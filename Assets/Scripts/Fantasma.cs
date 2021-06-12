using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;

    private Rigidbody fantasma;

    [SerializeField]
    float salto = 5;

    public float translate;

    Vector3 fantasmaPosicaoOriginal;

    Quaternion fantasmaOrientacaoOriginal;

    void Start()
    {
        fantasmaPosicaoOriginal = transform.position;
        fantasmaOrientacaoOriginal = transform.rotation;
        fantasma = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        translate = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, translate);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(fantasma.velocity.y) < 0.001f)
        {
           fantasma.AddForce(new Vector3(0, salto, 0), ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coletavel"))
        {
            other.gameObject.SetActive(false);
            GameObject.Find("Gameplay").GetComponent<Gameplay>().Pontuacao();
        }

        if (other.CompareTag("Respawn"))
        {
            transform.position = fantasmaPosicaoOriginal;
            transform.rotation = fantasmaOrientacaoOriginal;
        }
    }

}
