using System;
using UnityEngine;

public enum musicGaner {pop,rock,metal,electric,classic}


public class AudianceGanerPrefernce {

    public musicGaner type;
    public int preferedLevel;

	public AudianceGanerPrefernce(musicGaner type)
    {
        this.type = type;
        this.preferedLevel = S.random.Next(1,10);
    }
}

public class AudianceSongPrefernce {

    public Songs song;
    public int preferedLevel;

    public AudianceSongPrefernce(Songs song)
    {
        this.song = song;
        this.preferedLevel = S.random.Next(1, 10);
    }
}

public class AudianceArtistPrefernce {

    public Artists artist;
    public int preferedLevel;

	public AudianceArtistPrefernce(Artists artist)
    {
        this.artist = artist;
        this.preferedLevel = S.random.Next(1,10);
    }
}
