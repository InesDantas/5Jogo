using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinalLv3 : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
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
