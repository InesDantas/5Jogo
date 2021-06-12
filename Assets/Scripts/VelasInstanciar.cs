using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelasInstanciar : MonoBehaviour
{
    [SerializeField]
    GameObject vela;

    private void Awake()
    {
        GameObject novaVela = Instantiate(vela, transform);
        novaVela.transform.position = new Vector3(8.64f, 5.09f, 5.38f);

        GameObject novaVela1 = Instantiate(vela, transform);
        novaVela1.transform.position = new Vector3(7.26f, 5.6f, 5.38f);

        GameObject novaVela2 = Instantiate(vela, transform);
        novaVela2.transform.position = new Vector3(16.18f, 6.61f, 5.38f);

        GameObject novaVela3 = Instantiate(vela, transform);
        novaVela3.transform.position = new Vector3(20.86f, 7.34f, 5.38f);

        GameObject novaVela4 = Instantiate(vela, transform);
        novaVela4.transform.position = new Vector3(12.47f, 9.7f, 5.38f);

        GameObject novaVela5 = Instantiate(vela, transform);
        novaVela5.transform.position = new Vector3(10.42f, 10.31f, 5.38f);

        GameObject novaVela6 = Instantiate(vela, transform);
        novaVela6.transform.position = new Vector3(11.53f, 12.16f, 5.38f);

        GameObject novaVela7 = Instantiate(vela, transform);
        novaVela7.transform.position = new Vector3(14.1f, 2.35f, 5.38f);

        GameObject novaVela8 = Instantiate(vela, transform);
        novaVela8.transform.position = new Vector3(15.68f, 4.09f, 5.38f);
    }
}
