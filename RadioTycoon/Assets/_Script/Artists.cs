using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artists {

    // Use this for initialization
    public static List<Artists> allArtists = new List<Artists>();
    public int id;
    public static int id_seq = 0;
    public string name;
    public int famous;
    public float price;
    public List<musicGaner> artistGaners = new List<musicGaner>();
    public List<Songs> artistSongs = new List<Songs>();
    
    public Artists(List<musicGaner> artistGaners, List<Songs>artistSongs, string name, int famous)
    {
        this.id = id_seq++;
        this.artistGaners = artistGaners;
        this.artistSongs = artistSongs;
        this.name = name;
        this.famous = famous;
        this.price = Random.Range(1000, 2000);
    }

}
