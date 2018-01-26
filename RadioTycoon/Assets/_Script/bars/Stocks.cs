using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Stocks : MonoBehaviour
    {
        private const int AUDIANCE_GRAPH_BARS_AMOUNT = 0;
        private const int BALANCE_GRAPH_BARS_AMOUNT = 0;
        private List<int> audianceGraph;
        private List<int> balanceGraph;

        public Stocks()
        {
            audianceGraph = new List<int>(AUDIANCE_GRAPH_BARS_AMOUNT);
            balanceGraph = new List<int>(BALANCE_GRAPH_BARS_AMOUNT);
        }
    

    float totalTime = 120f; //2 minutes

    private void Update()
    {
        totalTime -= Time.deltaTime;
        UpdateLevelTimer(totalTime);
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

       // timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
