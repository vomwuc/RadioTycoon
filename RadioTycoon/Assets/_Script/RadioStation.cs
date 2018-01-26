using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioStation {
    public int balance;
    public MusicModel music;

	public RadioStation()
    {
        balance = 1500;
        music = new MusicModel(Artists.allArtists[0].artistSongs[0]);
    }
}
