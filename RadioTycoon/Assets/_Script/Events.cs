using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class GameEvent
{

    public static Dictionary<string, List<GameEvent>> all_GameEvent = new Dictionary<string, List<GameEvent>>();
    string eventTitle;
    int eventPower;// 1 to 10
    int GameEventspeed;
    int probability;
    bool isPositive;
    string sceneToLoad;

    public static void init()
    {
        all_GameEvent["Artist_event"].Add(new NewsPapperArtistEvent(":B make a new song",3,3 , true,10));
        all_GameEvent["Artist_event"].Add(new NewsPapperArtistEvent("paparazi on :B", 3, 3, true,10));
        all_GameEvent["Artist_event"].Add(new NewsPapperArtistEvent("tax case against :B", 3, 3, true,10));


    }

    public GameEvent(string eventTitle, int eventPower, int GameEventspeed , bool isPositive , int probability)
    {
        this.eventTitle = eventTitle;
    //    this.eventTexture = eventTexture;
        this.eventPower = eventPower;
        this.GameEventspeed = GameEventspeed;
    }

    public class newsPapperGameEvent : GameEvent
    {
        public newsPapperGameEvent(string eventTitle, int eventPower, int GameEventspeed , bool isPositive , int probability) : base(eventTitle, eventPower, GameEventspeed , isPositive,probability)
        {
        }

        public void Update()
        {

        }

    }

    public class NewsPapperArtistEvent : newsPapperGameEvent
    {
        Artists artist;

        public NewsPapperArtistEvent(string eventTitle, int eventPower, int GameEventspeed , bool isPositive , int probability) : base(eventTitle, eventPower, GameEventspeed , isPositive,probability)
        {
            artist = Artists.allArtists[0];
            Regex.Replace(eventTitle, ":B", artist.name);
        }
    }

    public class NewsPapperRadioStationEvent : newsPapperGameEvent
    {
        RadioStation radioStation;

        public NewsPapperRadioStationEvent(string eventTitle, int eventPower, int GameEventspeed , bool isPositive , int probability) : base(eventTitle, eventPower, GameEventspeed , isPositive,probability)
        {

            Regex.Replace(eventTitle, ":B", radioStation.name);
        }
    }

    public class NewsPapperEmergencyEvent : newsPapperGameEvent
    {
        List<Artists> artists;
        List<RadioStation> radioStations;

        public NewsPapperEmergencyEvent(string eventTitle, int eventPower, int GameEventspeed , bool isPositive , int probability) : base(eventTitle, eventPower, GameEventspeed , isPositive,probability)
        {
        }
    }
}