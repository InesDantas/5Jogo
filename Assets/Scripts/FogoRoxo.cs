using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogoRoxo : MonoBehaviour
{
    [SerializeField]Light luzRoxa;
    [SerializeField]float intensidadeMax = 20f;
    [SerializeField]GameObject luz;
    [SerializeField]float duracao = 2f;
    void Update()
    {
        var amplitude = Mathf.PingPong(Time.time, duracao);
        amplitude = amplitude / duracao * 0.5f + 0.5f;
        luzRoxa.intensity = intensidadeMax * amplitude;
    }
}
