using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class FishInfo
{
    public string[] fishName = new string[4] {"clownfish", "tuna", "shark", "swordfish"};
    public string species;
    public float newLength;
    //public float updateLength;
    public int newValue;
    private float fishLength;
    private int fishValue;
    public int x;


    
    public void RandomInfo()
    {
        species = fishName[Random.Range(0, fishName.Length)];
        newLength = Random.Range(1, 10);
        newValue = Random.Range(1, 10);
    }

    // public void SetInitialStats(float newLength)
    // {
    //     //fishName = fishName;
    //     updateLength = newLength;
    //     //fishValue = newValue;
    // }
}
