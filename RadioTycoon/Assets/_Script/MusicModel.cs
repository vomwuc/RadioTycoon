using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicModel : MonoBehaviour {

    List<musicType> type = new List<musicType>();
    Artists artist;
    Songs song;

    public MusicModel(Songs song)
    {
        this.song = song;
        this.artist = song.artist;
        this.type = song.artist.artistTypes;
    }
    
}
