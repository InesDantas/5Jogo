using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarColetavel : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
    }
}
