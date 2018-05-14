﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds the statistics for every level
/// </summary>
public class Level_Stats : MonoBehaviour {
    
    // Holds the status of the level complition
    [SerializeField]
    private bool is_complete;

    // Holds time that has passed since the scene has started
    [SerializeField]
    private float leveltime;

    //Holds the amount of saved spheres
    [SerializeField]
    private int savedspheres;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        //updates the leveltime
        leveltime = Time.timeSinceLevelLoad;	
	}

    /**
     *  Speichermöglichkeit für das Speichern der Farben
     * 
    private bool[] colorful;

    public void Savecolors()
    {
        GameObject[] go = FindObjectsOfType<GameObject>();
        foreach(GameObject element in go)
        {
            colorful = element.GetComponent<Coloration>().GetIsColorful();
        }
    }
    **/
}
