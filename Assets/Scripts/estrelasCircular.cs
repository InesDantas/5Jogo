using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// prováveis asneiras feitas pela ana seguindo o tutorial https://www.youtube.com/watch?v=OwIE3GI8Rdg 

public class estrelasCircular : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f)*Time.deltaTime); 
    }

}
