using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerB1 : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;

    [SerializeField]
    private Animator porta = null;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fantasma"))
        {
            audio = GetComponent<AudioSource>();
            porta.Play("PortaAbrir1", 0, 0.0f);
            gameObject.SetActive(false);
        }
    }
}
