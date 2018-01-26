using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour {
    private const int AUDIANCE_GRAPH_BARS_AMOUNT = 5;
    private const int BALANCE_GRAPH_BARS_AMOUNT = 5;
    private List<int> audianceGraph;
    private List<int> balanceGraph;
    float totalTime = 60f; //1 minutes


    // Use this for initialization
    void Start () {
        audianceGraph = new List<int>(AUDIANCE_GRAPH_BARS_AMOUNT);
        balanceGraph = new List<int>(BALANCE_GRAPH_BARS_AMOUNT);

    }
	
	// Update is called once per frame
	void Update () {
        totalTime -= Time.deltaTime;
        UpdateLevelTimer(totalTime);
    }

    public void UpdateLevelTimer(float totalSeconds) {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);
    
        string formatedSeconds = seconds.ToString();
    
        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        if (totalSeconds == 0)
        {

        }
    }
}

