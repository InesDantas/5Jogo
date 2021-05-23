using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaPortas : MonoBehaviour
{
    [SerializeField]
    float velocidade = 2;

    private Rigidbody fantasma;

    bool fantasmaTrigger = false;

    [SerializeField]
    float tempoDeEspera = 2f;

    float tempoDecorrido = 0f;

    // Start is called before the first frame update
    void Start()
    {
        fantasma = GetComponent<Rigidbody>();
        fantasmaTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        float translate = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        float updown = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, updown);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport"))
        {
            fantasmaTrigger = true;
            tempoDecorrido += Time.deltaTime;
            velocidade = 0;

          if (tempoDecorrido >= tempoDeEspera)
          {
                velocidade = 2;
          }
        }
        

    }*/


}
