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
}
