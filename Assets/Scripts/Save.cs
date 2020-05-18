using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    EverlightSaveSystem PlayerSaveData;

    public void Start()
    {
        PlayerSaveData = FindObjectOfType<EverlightSaveSystem>();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("LoadSaved", 1);
        PlayerPrefs.SetInt("SavedGame", SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Game Saved");
        PlayerSaveData.PlayerSaveData();
    }
}
