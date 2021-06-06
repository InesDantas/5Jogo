using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PonteAtiva : MonoBehaviour
{
    [SerializeField]
    Pontes[] pontes;

    // Update is called once per frame
    void OnTriggerEnter()
    {
        for (int i = 0; i < pontes.Length; i++)
        {
            pontes[i].Activar();
        }
    }
}
