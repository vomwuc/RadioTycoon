using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Songs
{

    // Use this for initialization
    public Artists artist;
    public string name;
    public int famous;

    public Songs(Artists artist,string name, int famous)
    {
        this.artist = artist;
        this.name = name;
        this.famous = famous;
    }

}
