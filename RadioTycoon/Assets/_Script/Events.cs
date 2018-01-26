using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events
{

    string eventTitle;
    string eventDescription;
    int eventPower;// 1 to 10
    int eventSpeed;// 1 to 10
    string sceneToLoad;

    public Events(string eventTitle, string eventDescription, int eventPower, int eventSpeed)
    {
        this.eventTitle = eventTitle;
        this.eventDescription = eventDescription;
        this.eventPower = eventPower;
        this.eventSpeed = eventSpeed;
    }

    public class newsPapperEvents : Events
    {
        public newsPapperEvents(string eventTitle, string eventDescription, int eventPower, int eventSpeed) : base(eventTitle, eventDescription, eventPower, eventSpeed)
        {
        }

        public void Update()
        {

        }

    }

    public class NewsPapperArtistEvent : newsPapperEvents
    {
        Artists artist;

        public NewsPapperArtistEvent(string eventTitle, string eventDescription, int eventPower, int eventSpeed) : base(eventTitle, eventDescription, eventPower, eventSpeed)
        {
        }
    }

    public class NewsPapperRadioStationEvent : newsPapperEvents
    {
        RadioStation radioStation;

        public NewsPapperRadioStationEvent(string eventTitle, string eventDescription, int eventPower, int eventSpeed) : base(eventTitle, eventDescription, eventPower, eventSpeed)
        {
        }
    }

    public class NewsPapperEmergencyEvent : newsPapperEvents
    {
        List<Artists> artists;
        List<RadioStation> radioStations;

        public NewsPapperEmergencyEvent(string eventTitle, string eventDescription, int eventPower, int eventSpeed) : base(eventTitle, eventDescription, eventPower, eventSpeed)
        {
        }
    }
}