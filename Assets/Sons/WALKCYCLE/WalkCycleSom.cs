using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkCycleSom : MonoBehaviour
{
    public AudioSource walkCycleSound;
    void Update()

    //adaptado de https://www.youtube.com/watch?v=DMJfQbgz_zo e https://answers.unity.com/questions/1502776/how-do-i-play-a-sound-when-pressing-the-w-key-and.html
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            if(!walkCycleSound.isPlaying)
            {
                walkCycleSound.Play();
            }
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            walkCycleSound.Stop();
        }
       if (Input.GetButtonDown("Jump"))
        {
            walkCycleSound.Stop();
        }
        if (Input.GetButtonUp("Jump"))
        {
            walkCycleSound.Play();
        }

    }
}

