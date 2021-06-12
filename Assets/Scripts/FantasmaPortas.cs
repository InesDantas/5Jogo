using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaPortas : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5;

    private Rigidbody fantasma;

    public float translate;

    public bool cima = true;

    // Start is called before the first frame update
    public void Start()
    {
        fantasma = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        translate = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        if(CanGoUp())
        {
            float updown = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
            transform.Translate(0, 0, updown);
        }
    }

    private bool CanGoUp()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit, 2f))
        {
            if(hit.collider.gameObject.tag == "Ponte")
            {
                cima = false;
                GameObject walkcycle = GameObject.Find("Walkcycle");
                AnimacaoFantasmaPortas animacaofantasmaPortas = walkcycle.GetComponent<AnimacaoFantasmaPortas>();
                animacaofantasmaPortas.animator.SetBool("Top", false);

                return false;
            }

            if (hit.collider.gameObject.tag == "TopView")
            {
                cima = true;
                GameObject walkcycle = GameObject.Find("Walkcycle");
                AnimacaoFantasmaPortas animacaofantasmaPortas = walkcycle.GetComponent<AnimacaoFantasmaPortas>();
                animacaofantasmaPortas.animator.SetBool("Top", true);
            }
        }

        return true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("RotateDown"))
        {
            transform.rotation = Quaternion.Euler(90, 270, -90);
        }

        if (other.CompareTag("RotateUp"))
        {
            transform.rotation = Quaternion.Euler(-90, 270, -90);
        }

        if (other.CompareTag("RotateSide"))
        {
            transform.rotation = Quaternion.Euler(0, 270, -90);
        }
    }
}
