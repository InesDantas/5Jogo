using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzFinal : MonoBehaviour
{
    [SerializeField]GameObject Trigger;
    [SerializeField]Light luzAzul;
    [SerializeField]float intensidadeMax = 6f;
    [SerializeField]GameObject luz;
    bool luzAtiva;
    [SerializeField] Pontes[] pontes;
    [SerializeField]Animator porta = null;
    void Start()
    {
        luzAtiva = false;
        luzAzul.intensity = 0;
    }

    void Update()
    {
        Debug.Log(AreAllActive());
        if(AreAllActive() == true)
        {
            luzAtiva=true;
            luz.SetActive(luzAtiva);
            var amplitude2 = Mathf.PingPong(Time.time, intensidadeMax);
            luzAzul.intensity = amplitude2;
            porta.Play("PortaAbrir", 0, 0.0f);
            gameObject.SetActive(false);
            Trigger.SetActive(true);
        }
    }

    bool AreAllActive()
    {
        for(int i = 0; i < pontes.Length; i++) 
        {
            if(!pontes[i].IsActive()) 
            {
                return false;
            }       
        }
        return true;
    }
}