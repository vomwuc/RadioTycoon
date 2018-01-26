using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicModel : MonoBehaviour {

    public List<musicGaner> geners = new List<musicGaner>();
    public Artists artist;
    public Songs song;

    public MusicModel(Songs song)
    {
        this.song = song;
        this.artist = song.artist;
        this.geners = song.artist.artistGaners;
    }
    
}
