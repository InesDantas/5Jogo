using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base1Lv5 : MonoBehaviour
{
    [SerializeField] Material matBase;

    float duracao = 1f;

    void Start()
    {
        matBase.SetFloat("Vector1_54DC5DFC", 0);
    }

    // Update is called once per frame
    void Update()
    {
        var amplitude = Mathf.PingPong(Time.time, duracao);
        amplitude = amplitude / duracao * 0.1f + 0.1f;
        matBase.SetFloat("Vector1_54DC5DFC", amplitude);
    }
}
