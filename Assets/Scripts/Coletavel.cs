using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    [SerializeField]
    GameObject coletavel;

    private void Awake()
    {
        GameObject novoColetavel = Instantiate(coletavel, transform);
        novoColetavel.transform.position = new Vector3(7.12f, 8.83f, 3.26f);

        GameObject novoColetavel2 = Instantiate(coletavel, transform);
        novoColetavel2.transform.position = new Vector3(17.7f, 10.34f, 3.26f);

        GameObject novoColetavel3 = Instantiate(coletavel, transform);
        novoColetavel3.transform.position = new Vector3(13.15f, 6.55f, 3.26f);

        GameObject novoColetavel4 = Instantiate(coletavel, transform);
        novoColetavel4.transform.position = new Vector3(20.7f, 6.6f, 3.26f);

        GameObject novoColetavel5 = Instantiate(coletavel, transform);
        novoColetavel5.transform.position = new Vector3(10.9f, 2f, 3.26f);
    }
}
