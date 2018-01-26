using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicModel : MonoBehaviour {

    List<musicGaner> geners = new List<musicGaner>();
    Artists artist;
    Songs song;

    public MusicModel(Songs song)
    {
        this.song = song;
        this.artist = song.artist;
        this.geners = song.artist.artistGaners;
    }
    
}
