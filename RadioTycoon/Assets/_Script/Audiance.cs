using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiance {

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
        id = id_sequence++;
        PreferedGaners = new List<AudianceGanerPrefernce>();
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
    }

    void Update()
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

        loveStation /= (float)(radioStation.SoundQUality / 20);

        float pateince_factor = 1 / (pateince + IQ) * (71 - age);
        float current_avg = 0;
        float all_avg = 0;
        for(int i =grades.Count - 1 ;i>= 0;i--)
        {
            if (i > grades.Count - 1 - 5)
            {
                current_avg += grades[i];
            }
            all_avg += grades[i];
        }
        all_avg = all_avg / grades.Count;

        if(current_avg > all_avg )
        {
           // Remove from radioStation
        }

        grades.Add(loveStation);


    }
}
