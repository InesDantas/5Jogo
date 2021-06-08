using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiAparecer : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject menuFim;

    void OnTriggerEnter()
    {
        menuFim.SetActive(true);
    }

    void Pause()
    {
        menuFim.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
