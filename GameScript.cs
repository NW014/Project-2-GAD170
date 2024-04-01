using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    //public List<string> fishName = new List<string> {"apple", "fish"};
    //public FishScript fishScript;
    public GameObject fishPrefab;
    public GameObject[] Aquarium;
    public Vector3 spawnPosition;
    public bool rLocation;
    //int fishName;
    float fishLength;
    //float newLength = 0;

    public int x = 0;
    public int y = 0;
    public int z;
    public int turn = 0;
    public GameObject newFish;

    public float test = 0;
    public float newFishLength;
    public float oldFishLength;

    public bool fishOnLine = false;


    public GameObject testObject;

    // Start is called before the first frame update
    void Start()
    {
        turn += 1;
        Debug.Log("It is now turn " + turn);
        newFish = Instantiate(fishPrefab);
    }

    
    

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     OnSpawnAPrefab();
        //     //Debug.Log("Press N to delete new fish.");
        // }

        // while (x < 10)
        // {
        //     if(Input.GetKeyDown(KeyCode.A))
        //     {
        //         Aquarium[x] = Instantiate(fishPrefab);// as GameObject;
        //         x++;
        //     }
            
        // }

        //GAMEOBJECT.GetComponent<ClassName>().VariableName = 4;

        // if (x < 10 && Input.GetKeyDown(KeyCode.A))
        // {
        //     Aquarium[x] = Instantiate(fishPrefab);// as GameObject;
        //     x++;          
        //     surviveCheck();
        // }

        
        // while (turn < 10 && Input.GetKeyDown(KeyCode.A))   // important
        // {
        //     newFish = Instantiate(fishPrefab);// as GameObject;        

        //     Debug.Log("Do you want to keep the fish?");

        //     while (!Input.GetKeyDown(KeyCode.Y) || !Input.GetKeyDown(KeyCode.N))
        //     {
        //         if (Input.GetKeyDown(KeyCode.Y))
        //         {
        //             Aquarium[x] = newFish;
        //             x++;
        //             surviveCheck();
        //         }
        //         else if (Input.GetKeyDown(KeyCode.N))
        //         {
        //             Destroy(newFish);
        //             Debug.Log("Press A to fish something up.");
        //         }
        //     }
        //     turn++;
        //     Debug.Log("A turn has passed. " + (10 - turn) + " turn(s) remaining.");
        // }

        if (x == 10 && Input.GetKeyDown(KeyCode.L))
        {
            GameObject testObject = Aquarium[1];
            //Debug.Log(testObject.GetComponent<int>());
            float test = testObject.GetComponent<FishScript>().updateLength;
            
            // if (test == null)
            // {
            //     test = 69;
            // }
            Debug.Log(test);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            valueCheck();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            surviveCheck();
        }
    }

//     public IEnumerator fishing()
//     {

//         gameScript.fishOnLine = true;
//         Debug.Log("Do you wish to keep this fish? Press Y for yes or N for no.");

//         while (!Input.GetKeyDown(KeyCode.Y) || !Input.GetKeyDown(KeyCode.N))
//         {
//             yield return new WaitUntil(fishGone);
//         }

//         bool fishGone()
//         {
//             if (Input.GetKeyDown(KeyCode.Y))
//             {
//                 gameScript.Aquarium[gameScript.x-1] = gameScript.newFish;
//                 gameScript.x++;
//                 //surviveCheck();
//                 gameScript.fishOnLine = false;
//                 return true;
//                 }
//             else if (Input.GetKeyDown(KeyCode.N))
//             {
//                 Destroy(gameScript.newFish);
//                 Debug.Log("Fish is thrown away.");
//                 gameScript.fishOnLine = false;
//                 return true;
//             }
//             else
//             {
//                 return false;
//             }        
//         } 
//     }       
// }


    public void valueCheck()
    {
        int totalValue = 0;
        // Gets the fish value for each fish in the aquarium.
        for (z = 0; z < x; z++)
        {         
            if (Aquarium[z] != null)
            {
                totalValue += Aquarium[z].GetComponent<FishScript>().updateValue;
            }
            else 
            {
                totalValue += 0;
            }

            // foreach (GameObject fishPrefab in Aquarium)
            // {
            //     totalValue += Aquarium[z].GetComponent<FishScript>().updateValue;
            // }
        }
        Debug.Log("Total value of your aquarium is: $" + totalValue);
    }

    public void surviveCheck()
    {
        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     Destroy(Aquarium[x-1]);
        //     x -= 1;
        // }

        float newFishLength = Aquarium[x-1].GetComponent<FishScript>().updateLength;
        float oldFishLength = Aquarium[y].GetComponent<FishScript>().updateLength;
        
        for (y = 0; y < (x-1); y++)
        {
            // if (newFishLength >= (oldFishLength * 2))
            if (newFishLength >= (oldFishLength * 2))
            {
                Destroy(Aquarium[y]);
                x -= 1;
                Debug.Log("Fish " + y + " with a length of " + oldFishLength + " has been eaten by fish " + x + " which has a length of " + newFishLength);
            }
            else
            {
                Debug.Log("Fish " + y + " with length of " + oldFishLength + " cannot be eaten by fish " + (x-1) + " with length of " + newFishLength);
            }
        }


    }


    




    //spawn fish objects in the game 
    void OnSpawnAPrefab()
    {
        if(rLocation)
        {
            float x = Random.Range(-4, 5);
            float y = Random.Range(-1.5f, 3);
            float z = Random.Range(-2, 2);
            Instantiate(fishPrefab, new Vector3(x, y, z), Quaternion.identity);
        }
        else
        {
            Instantiate(fishPrefab, spawnPosition, Quaternion.identity);
        }
    }
}

//
