using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimdeCena : MonoBehaviour
{
 
   [SerializeField] GameObject Cena;
    void OnEnable()
    {
        Cena.SetActive(false);
    }
    
}
