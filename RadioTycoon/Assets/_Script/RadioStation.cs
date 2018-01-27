using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioStation {
    public static List<RadioStation> allStations;
    public List<Audiance> audianceList;
    public static int id_seq = 1;
    public int id;
    public string name;
    public float balance;
    public MusicModel music;
    public float SoundQUality;
    public float SoundRange;
    public bool isComercial;
    public int COMERCIAL_FACTOR = 2;
    public int framesInComercial;
    public int framesWithMusic = 0;

	public RadioStation(string name)
    {
        audianceList = new List<Audiance>();
        id = id_seq++;
        balance = 1500;
        this.name = name;
        music = new MusicModel(Artists.allArtists[0].artistSongs[0]);
        SoundQUality = 30;
        SoundRange = 30;
    }

    public void Update()
    {
        if(isComercial == true)
        {
            framesInComercial++;
            framesWithMusic = 0;
        }
        else
        {
            framesInComercial = 0;
            framesWithMusic++;
        }
    }
}
