using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioStation {
    public int balance;
    public MusicModel music;
    public float SoundQUality;
    public float SoundRange;

	public RadioStation()
    {
        balance = 1500;
        music = new MusicModel(Artists.allArtists[0].artistSongs[0]);
        SoundQUality = 30;
        SoundRange = 30;
    }
}
