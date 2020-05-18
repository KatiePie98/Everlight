using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverlightSaveSystem : MonoBehaviour
{
    public GameObject player;

    public void PlayerSaveData()
    {
        PlayerPrefs.SetInt("Saved", 1);
        PlayerPrefs.Save();
    }
}
