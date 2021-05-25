using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerA3 : MonoBehaviour
{
    [SerializeField]
    private Animator porta = null;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fantasma"))
        {
            porta.Play("PortaAbrir4", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }
}
