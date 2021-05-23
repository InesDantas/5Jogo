using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerA1 : MonoBehaviour
{

    [SerializeField]
    private Animator porta = null;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fantasma"))
        {
            porta.Play("PortaAbrir10", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }
}
