﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaPortas : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5;

    private Rigidbody fantasma;


    // Start is called before the first frame update
    public void Start()
    {
        fantasma = GetComponent<Rigidbody>();
    }

    public void Update()
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
        if(Physics.Raycast(transform.position, -transform.up, out hit, 2f))
        {
            if(hit.collider.gameObject.tag == "Ponte")
            {
                return false;
            }
        }

        return true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("RotateDown"))
        {
            //transform.Rotate(180, 0, 0);
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
