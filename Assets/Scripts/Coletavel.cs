using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    [SerializeField]
    GameObject coletavel;

    private void Awake()
    {
        float x = 44f;
        for (int i = 1; i <= 5; i++)
        {
            GameObject novoColetavel = Instantiate(coletavel, transform);
            novoColetavel.transform.position = new Vector3(x, 0f, 0f);
            x += 1f;
        }
    }
}
