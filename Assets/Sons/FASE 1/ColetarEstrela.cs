using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarEstrela : MonoBehaviour
{
    public AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }
}
