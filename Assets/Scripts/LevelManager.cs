using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject tileMapA;
    public GameObject tileMapB;
    public GameObject tileMapC;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;

        tileMapB.SetActive(false);
        tileMapC.SetActive(true);

    }

    public void SwitchTileMap()
    { 

        if (tileMapB.activeSelf == true)
        {
            tileMapB.SetActive(false);
        }
        else
        { 
            tileMapB.SetActive(true); 
        }

        if (tileMapC.activeSelf == true)
        {
            tileMapC.SetActive(false);
        }
        else
        { 
            tileMapC.SetActive(true); 
        }

    }

    
}
