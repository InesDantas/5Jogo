﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzFinal : MonoBehaviour
{
    [SerializeField]
    Light luzAzul;
    [SerializeField]
    float intensidadeMax = 6f;
    void Start()
    {
        luzAzul.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
           var amplitude2 = Mathf.PingPong(Time.time, intensidadeMax);
      luzAzul.intensity = amplitude2;
    }
}