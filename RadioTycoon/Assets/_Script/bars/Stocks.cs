using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Stocks : MonoBehaviour {
    private const int AUDIANCE_GRAPH_BARS_AMOUNT = 5;
    private const int BALANCE_GRAPH_BARS_AMOUNT = 5;
    private List<int> audianceGraph;
    private List<int> balanceGraph;
    private const float UPDATE_DURATION = 60f; // 1 minute.
    float totalTime = 60f; //1 minutes


    // Use this for initialization
    void Start () {
        audianceGraph = new List<int>(AUDIANCE_GRAPH_BARS_AMOUNT);
        balanceGraph = new List<int>(BALANCE_GRAPH_BARS_AMOUNT);

    }
	
	// Update is called once per frame
	void Update () {
        totalTime -= Time.deltaTime;
        totalTime = UpdateBarTimer(UPDATE_DURATION, totalTime, AUDIANCE_GRAPH_BARS_AMOUNT, BALANCE_GRAPH_BARS_AMOUNT);
    }

    public float UpdateBarTimer(float UPDATE_DURATION, float totalSeconds, int audianceMaxBarsAmount, int balanceMaxBarsAmount) {
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
            audianceGraph[audianceMaxBarsAmount - 1] = RadioStation.allStations[0].audianceList.Count;
            balanceGraph[audianceMaxBarsAmount - 1] = (int)RadioStation.allStations[0].balance;

            for (int bar = audianceMaxBarsAmount - 2; bar >= 0; bar--)
            {
                audianceGraph[bar] = audianceGraph[bar + 1];
                balanceGraph[bar] = balanceGraph[bar + 1];
            }
            totalSeconds = UPDATE_DURATION;
        }

        return totalSeconds;
    }
}

