using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artists {

    // Use this for initialization
    public static List<Artists> allArtists = new List<Artists>();
    public string name;
    public int famous;
    public List<musicType> artistTypes = new List<musicType>();
    public List<Songs> artistSongs = new List<Songs>();
    
    public Artists(List<musicType> artistTypes,List<Songs>artistSongs,string name,int famous)
    {
        this.artistTypes = artistTypes;
        this.artistSongs = artistSongs;
        this.name = name;
        this.famous = famous;
    }

}
