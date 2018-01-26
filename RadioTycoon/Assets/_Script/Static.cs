using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour {

    public static System.Random random = new System.Random();
    public static int MIN_ABILITY_VALUE = 0;
    public static int MAX_ABILITY_VALUE = 10;

    public static void init()
    {
        Artists.allArtists = new List<Artists>();
        Artists.allArtists.Add(new Artists(new List<musicGaner>() { musicGaner.pop }, new List<Songs>(),"Raz samuel",1));
        Artists.allArtists.Add(new Artists(new List<musicGaner>() { musicGaner.electric , musicGaner.metal }, new List<Songs>(), "Eminem", 10));
        Artists.allArtists.Add(new Artists(new List<musicGaner>() { musicGaner.rock}, new List<Songs>(), "Metalica", 8));
        Artists.allArtists.Add(new Artists(new List<musicGaner>() { musicGaner.pop }, new List<Songs>(), "John doe",5));
        //    Artists.allArtists.Add(new Artists(new List<musicGaner>() { musicGaner.pop }, new List<Songs>(), "Raz samuel", 1));
        //  Artists.allArtists.Add(new Artists(new List<musicGaner>() { musicGaner.pop }, new List<Songs>(), "Raz samuel", 1));
        Songs.allSongs = new List<Songs>();
        Songs song;
        foreach (Artists artist in Artists.allArtists)
        {
            
            switch(artist.id)
            {
                case 0:
                    song = new Songs(artist, "Its rain", 5);
                    artist.artistSongs.Add(song);
                    song = new Songs(artist, "Drop his pain", 2);
                    artist.artistSongs.Add(song);
                    break;
                case 1:
                     song = new Songs(artist, "Go in back to the corner", 5);
                    artist.artistSongs.Add(song);
                    song = new Songs(artist, "Im not moving", 4);
                    artist.artistSongs.Add(song);
                    break;
                case 2:
                     song = new Songs(artist, "someone im waiting for", 8);
                    artist.artistSongs.Add(song);
                    song = new Songs(artist, "because if 1 day", 3);
                    artist.artistSongs.Add(song);
                    break;
                case 3:
                     song = new Songs(artist, "Maybe you comeback", 1);
                    artist.artistSongs.Add(song);
                    song = new Songs(artist, "yea", 9);
                    artist.artistSongs.Add(song);
                    break;
            }
        }
        List<GameEvent> temp = new List<GameEvent>() { new NewsPapperArtistEvent(":B make a new song", 3, 3, true, 10), new NewsPapperArtistEvent(":B make a new song", 3, 3, true, 10), new NewsPapperArtistEvent("paparazi on :B", 3, 3, true, 10), new NewsPapperArtistEvent("tax case against :B", 3, 3, true, 10) };
        GameEvent.all_GameEvent.Add("Artist_event", temp);
               RadioStation.allStations =  new List<RadioStation>() { new RadioStation("Fat warriors") };

    }
}
