using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public GameObject coletavelOriginal;

    private int pontos = 0;

    [SerializeField] Text textoPontos;

    void Update()
    {
        
    }

    public void Pontuacao()
    {
        pontos++;
        textoPontos.text = pontos.ToString() + "/5";

        if (pontos == 5)
        {
            Debug.Log("Yay");
            SceneManager.LoadScene(sceneName: "Nivel3");
        }
    }

}
