using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour // FROM: https://www.sitepoint.com/saving-data-between-scenes-in-unity/
{
    public static GlobalControl Instance;

    public float PlayerRep; // Sets the rep as a GLOBAL object

    void Awake() // If there is another instance, destroy that one and make sure that the instance is this one
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject); // This keeps the data alive so that it can be carried over to the next scene
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
