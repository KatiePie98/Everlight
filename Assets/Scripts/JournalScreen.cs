using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalScreen : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject JournalMenuUI;
    public GameObject PlayerUI;

    void Start()
    {
        JournalMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
    }

    void Resume()
    {
        PlayerUI.SetActive(true);
        JournalMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PlayerUI.SetActive(false);
        JournalMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
