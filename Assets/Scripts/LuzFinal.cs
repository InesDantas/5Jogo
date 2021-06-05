using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzFinal : MonoBehaviour
{
    [SerializeField]Light luzAzul;
    [SerializeField]float intensidadeMax = 6f;

    [SerializeField] Pontes[] pontes;

    void Start()
    {
        luzAzul.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(AreAllActive() == true)
        {
            
        }
        //var amplitude2 = Mathf.PingPong(Time.time, intensidadeMax);
        //luzAzul.intensity = amplitude2;

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