using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public float test = 69;
    //private int x = 0;
    private string fishName;
    //public float newLength;
    public string updateName
    {
        get
        {
            return fishName;
        }
        set
        {
            fishName = value;
            Debug.Log("This fish species is: " + fishName);
        }
    }
    private float fishLength;
    //private float newLength;
    public float updateLength
    {
        get
        {
            return fishLength;
        }
        set
        {
            fishLength = value;
            Debug.Log("This fish has a length of: " + fishLength);
            //Debug.Log("New length is: " + fishLength);
        }
    }
    private int fishValue;
    public int updateValue
    {
        get
        {
            return fishValue;
        }
        set
        {
            fishValue = value;
            //Debug.Log("New value is: " + fishValue);
        }
    }

    //float newLength;
    //private int fishValue;
    public FishingScript fishingScript;
    public FishInfo fishInfo = new FishInfo();




    // Start is called before the first frame update
    void Start()
    {
        //newLength = Random.Range(1, 5);
        //gameScript.GetLength();
        //Debug.Log(fishLength);
        //getFishData.SetInitialStats(fishLength);
        //gameScript.SetInitialStats(fishLength);


        fishInfo.RandomInfo();
        updateName = fishInfo.species;
        updateLength = fishInfo.newLength;
        updateValue = fishInfo.newValue;
        //x = fishInfo.x;
        //fishInfo.SetInitialStats(updateLength);
        //Debug.Log(fishLength);

        fishingScript.StartCoroutine("fishing");

    }

    // Update is called once per frame
    void Update()
    {
        // if (x == 0)
        // {
        //     if(Input.GetKeyDown(KeyCode.N))
        //     {
        //         gameObject.SetActive(false);
        //         x++;
        //     }
        //     else if(Input.GetKeyDown(KeyCode.Y))
        //     {
        //         x++;
        //     }
        // }
    }
}
