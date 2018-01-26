using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAnimation : MonoBehaviour {

    public List<Sprite> textures;
    int index = 0;
    public int shape = 3;
    int shapeIndex = 0;
    public bool draw;

    private void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update () {

        if(!draw)
        {
            this.GetComponent<SpriteRenderer>().sprite = null;
        }

        if (draw && shapeIndex++ % shape == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = textures[index++];
            index = index % (textures.Count);
        }
	}
}
