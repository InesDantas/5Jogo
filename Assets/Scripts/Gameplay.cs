using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public GameObject coletavelOriginal;

    void Start()
    {
        GameObject ColetavelClone = Instantiate(coletavelOriginal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
