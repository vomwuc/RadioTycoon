﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    RadioStation baseStation;
    int timeIndex = 0;
	// Use this for initialization
	void Start () {
        S.init();
        baseStation = RadioStation.allStations[0];

    }

    // Update is called once per frame
    void Update () {
     //   Debug.Log("time index:" + Random.Range(0, 2) % 2);
		if(timeIndex ++ % 60 == 0 && Random.Range(0,2) % 2 == 0)
        {
            new Audiance();
            Debug.Log(baseStation.audianceList.Count);
        }
	}
}
