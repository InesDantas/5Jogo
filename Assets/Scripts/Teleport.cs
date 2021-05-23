using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject fantasma;

    void OnTriggerEnter(Collider other)
    {
        fantasma.transform.position = teleportTarget.transform.position;
    }
}
