using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiance {

    public static List<Audiance> all_audiance = new List<Audiance>();
    public static int id_sequence;
    public int id;
    public List<AudianceGanerPrefernce>PreferedGaners;
    public List<AudianceArtistPrefernce> ArtistPrefernce;
    public List<AudianceSongPrefernce> PreferedSongs;
    public int pateince;
    public int extremism;
    public int IQ;
    public int age;
    public char gender;
    public string name;
    public RadioStation radioStation;
    public float min_grade_to_stay = 10;

    private List<float> grades = new List<float>();

    
    public Audiance()
    {
        radioStation = RadioStation.allStations[0];
        id = id_sequence++;
        PreferedGaners = new List<AudianceGanerPrefernce>();
        ArtistPrefernce = new List<AudianceArtistPrefernce>();
        PreferedSongs = new List<AudianceSongPrefernce>();
        pateince = S.random.Next(S.MIN_ABILITY_VALUE, S.MAX_ABILITY_VALUE);
        extremism = S.random.Next(S.MIN_ABILITY_VALUE, S.MAX_ABILITY_VALUE);
        IQ = S.random.Next(S.MIN_ABILITY_VALUE, S.MAX_ABILITY_VALUE);
        age = S.random.Next(10, 70);
        pateince = S.random.Next(S.MIN_ABILITY_VALUE, S.MAX_ABILITY_VALUE);
        gender = S.random.Next(1,2) % 2 == 1 ? 'M' : 'F';
        name = "RAZ SAMUEL";
        foreach (musicGaner m in Enum.GetValues(typeof(musicGaner)))
        {
           PreferedGaners.Add(new AudianceGanerPrefernce(m));
            
        }

        foreach(Artists artist in Artists.allArtists)
        {
            ArtistPrefernce.Add(new AudianceArtistPrefernce(artist));
        }
        foreach (Songs song in Songs.allSongs)
        {
            PreferedSongs.Add(new AudianceSongPrefernce(song));
        }

        radioStation.audianceList.Add(this);
    }

    public void Update()
    {

        float loveStation = 0;

        foreach (AudianceGanerPrefernce MyPreferedGener in PreferedGaners)
        {
            if(radioStation.music.geners.Contains(MyPreferedGener.type)) {
                loveStation += MyPreferedGener.preferedLevel;
            }
        }

        foreach (AudianceArtistPrefernce myPrefArtist in ArtistPrefernce)
        {
            if (radioStation.music.artist == (myPrefArtist.artist))
            {
                loveStation += (float) myPrefArtist.preferedLevel * 1.5f;
            }
        }

        foreach (AudianceSongPrefernce myPrefSong in PreferedSongs)
        {
            if (radioStation.music.song == (myPrefSong.song))
            {
                loveStation += (float)myPrefSong.preferedLevel * 2f;
            }
        }

        loveStation = !radioStation.isComercial ? loveStation * Mathf.Max((radioStation.framesWithMusic / 120),1) :loveStation / (radioStation.COMERCIAL_FACTOR * Math.Max(1, radioStation.framesInComercial / 120));
        loveStation /= (float)(radioStation.SoundQUality / 20);

        float pateince_factor = 1 / Math.Max(1,(pateince + IQ)) * (71 - age);
        float current_avg = 0;
        float all_avg = 0;
        int cnt = 0;
        for(int i = 0; i< grades.Count;i++)
        {
        current_avg += grades[i];
        cnt++;
        }
        current_avg /= cnt;

        grades.Add(loveStation);

        if(this.id == 1)
        {
            Debug.Log(loveStation);
        }

    }
}
