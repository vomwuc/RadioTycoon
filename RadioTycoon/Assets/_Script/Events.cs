using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events {

    string eventTitle;
    string eventDescription;
    int AudianceEffect ; // from 1 to 10
    int speedEffect; // How fast it will effect
    bool isEventPositive;
    string sceneToLoad;

    public Events(string eventTitle , string eventDescription , int AudianceEffect , int speedEffect)
    {
        this.eventTitle = eventTitle;
        this.eventDescription = eventDescription;
        this.AudianceEffect = AudianceEffect;
        this.speedEffect = speedEffect;
    }

    public class newsPapperEvents : Events
    {
        public newsPapperEvents(string eventTitle, string eventDescription, int AudianceEffect, int speedEffect) : base(eventTitle, eventDescription, AudianceEffect, speedEffect)
        {
            sceneToLoad = "newsPaperScene";
        }
    }

    public class StocksEvents : Events
    {
        public StocksEvents(string eventTitle, string eventDescription, int AudianceEffect, int speedEffect) : base(eventTitle, eventDescription, AudianceEffect, speedEffect)
        {
            sceneToLoad = "newsPaperScene";
        }
    }

    public class MaintenanceEvents : Events
    {
        public MaintenanceEvents(string eventTitle, string eventDescription, int AudianceEffect, int speedEffect) : base(eventTitle, eventDescription, AudianceEffect, speedEffect)
        {
            sceneToLoad = "newsPaperScene";
        }
    }

    public class EmergencyEvents : Events
    {
        public EmergencyEvents(string eventTitle, string eventDescription, int AudianceEffect, int speedEffect) : base(eventTitle, eventDescription, AudianceEffect, speedEffect)
        {
            sceneToLoad = "newsPaperScene";
        }
    }
}
