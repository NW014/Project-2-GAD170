using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingScript : MonoBehaviour
{
    //this acts as my Aquarium script...?

public GameScript gameScript;


public IEnumerator fishing()
    {

        gameScript.fishOnLine = true;
        Debug.Log("Do you wish to keep this fish? Press Y for yes or N for no.");

        while (!Input.GetKeyDown(KeyCode.Y) || !Input.GetKeyDown(KeyCode.N))
        {
            yield return new WaitUntil(fishGone);
        }

        bool fishGone()
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                gameScript.Aquarium[gameScript.x-1] = gameScript.newFish;
                gameScript.x++;
                //surviveCheck();
                gameScript.fishOnLine = false;
                return true;
                }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                Destroy(gameScript.newFish);
                Debug.Log("Fish is thrown away.");
                gameScript.fishOnLine = false;
                return true;
            }
            else
            {
                return false;
            }        
        } 
    }       
}
