using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaPortas : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5;

    private Rigidbody fantasma;

    // Start is called before the first frame update
    void Start()
    {
        fantasma = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float translate = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
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
        if(Physics.Raycast(transform.position, -transform.up, out hit, 1f))
        {
            if(hit.collider.gameObject.tag == "Ponte")
            {
                return false;
            }
        }

        return true;
    }

}
