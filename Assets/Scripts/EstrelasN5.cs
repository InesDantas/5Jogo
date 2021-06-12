using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstrelasN5 : MonoBehaviour
{
    NavMeshAgent estrela;
    Transform alvo;

    void Start()
    {
        estrela = GetComponent<NavMeshAgent>();
        alvo = GameObject.FindGameObjectWithTag("Fantasma").transform;
    }

    void Update()
    {
        estrela.destination = alvo.position;
    }
}
