using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showallartists : MonoBehaviour {

    RadioStation radioStation;
    public GameObject prefab;
    public GameObject parent;
    private int index = 0;
    public int yDiff;
	// Use this for initialization
	void Start () {
        index = 0;
        radioStation = RadioStation.allStations[0];
        Debug.Log(radioStation.ArtistBougth);
		foreach(Artists artist in radioStation.ArtistBougth)
        {
            foreach(Songs song in artist.artistSongs)
            {
                index++;
                GameObject obj = Instantiate(prefab, new Vector3(0, yDiff * index), new Quaternion(), parent.transform);
               obj.GetComponentInChildren<Text>().text = artist.name + "-" + song.name;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
