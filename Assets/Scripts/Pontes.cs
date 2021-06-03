using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontes : MonoBehaviour
{

    [SerializeField] Material matPonte;
    [SerializeField] Light luz;
    [SerializeField] GameObject luzObjeto;
    bool ponte;
    float tempo;
    [SerializeField] float originalRange = 4f;
    [SerializeField] float duracao = 3f;
    [SerializeField] float luzAparece = 1.3f;
    [SerializeField] float velocidade = 1f;
    float animacao = 1f;
    void Start()
    {
      ponte = false;
      luzObjeto.SetActive(false);
      luz.range = originalRange;
      matPonte.SetFloat("Vector1_54DC5DFC", 1);
    }
    void Update()
    {
      if(ponte == true)
      {
        tempo += Time.deltaTime;
        animacao = Mathf.MoveTowards(animacao, 0, (1 / velocidade) * Time.deltaTime);
        matPonte.SetFloat("Vector1_54DC5DFC", animacao);
        luzObjeto.SetActive(true);
        if(tempo > luzAparece)
        {
          var amplitude = Mathf.PingPong(Time.time, duracao);
          amplitude = amplitude / duracao * 1f + 1f;
          luz.range = originalRange * amplitude;
        }
      }
      
    }
    public void OnTriggerEnter()
    {
     ponte = true;
    }
}
