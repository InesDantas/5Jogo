using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;


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
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
        //Animacao
        //esperar
        //Load nova cena

    }
}
