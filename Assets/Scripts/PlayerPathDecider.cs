using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlayerPathDecider : MonoBehaviour
{
    public Flowchart flowchart;

    public float PlayerRep;

    public void saveRep()
    {
        GlobalControl.Instance.PlayerRep = PlayerRep; // Saves the reputation
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerRep = GlobalControl.Instance.PlayerRep; // Loads the player's saved reputation

        flowchart.SetIntegerVariable("PlayerRep", 5);
    }

    // Update is called once per frame
    void Update()
    {
        int PlayerRep = flowchart.GetIntegerVariable("Reputation");
        Debug.Log(PlayerRep);

        if (PlayerRep < 30)
        {
            // Create gameobjects/lists? each containing random sets of flowcharts
            // Pick random bad list or gameobject
            // Set that group of flowcharts as active
        }

        else if (PlayerRep < 50)
        {
            // Do the same here
            // Pick random netural list or gameobject
            // Set as active
        }

        else if (PlayerRep > 70)
        {
            // Do the same here
            // Pick random good list or gameobject
            // Set as active
        };
    }

}
