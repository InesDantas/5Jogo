﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// prováveis asneiras feitas pela ana seguindo o tutorial https://www.youtube.com/watch?v=zit45k6CUMk
public class ParallaxN1 : MonoBehaviour
{

    private float length, startposition;

    public GameObject camera;

    public float parallaxEffect;

    void Start()
    {
        startposition = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

 
    void FixedUpdate()
    {
        float distance = (camera.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startposition + distance, transform.position.y, transform.position.z);
    }
}
