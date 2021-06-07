using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Aspirador : MonoBehaviour
{

    NavMeshAgent aspirador;
    Transform alvo;

    // Start is called before the first frame update
    void Start()
    {
        aspirador = GetComponent<NavMeshAgent>();
        alvo = GameObject.FindGameObjectWithTag("Fantasma").transform;
    }

    // Update is called once per frame
    void Update()
    {
        aspirador.destination = alvo.position;
    }
}
