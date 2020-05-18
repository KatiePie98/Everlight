using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        PlayerPrefs.DeleteKey("TimeToLoad");
        PlayerPrefs.DeleteKey("Saved");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChapterOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChapterTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void ChapterThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }


    public void LoadGame()
    {
        if(PlayerPrefs.GetInt("LoadSaved") == 1 )
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("SavedGame"));
        }
        else
        {
            return;
        }
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
