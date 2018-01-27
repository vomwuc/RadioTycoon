using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateShop : MonoBehaviour
{

    public GameObject prefab;
    public int nRows;
    public int nCols;
    public int totalObjects;
    public float xDiff;
    public float yDiff;
    public GameObject parent;
    List<Artists> artistsToBuy;

    // Use this for initialization
    void Start()
    {
        artistsToBuy = Artists.allArtists;
        Debug.Log(artistsToBuy.Count);
        //  totalObjects = Text.Count;
        for (int i = 0; i < nRows; i++)
        {
            for (int j = 0; j < nCols; j++)
            {
                if ((i * nCols) + j < artistsToBuy.Count)
                {
                    GameObject obj = Instantiate(prefab, new Vector3(xDiff * j, yDiff * i, 1), new Quaternion(), parent.transform);
                    obj.transform.name = artistsToBuy[(i * nCols) + j].id.ToString();

                    obj.transform.localPosition = obj.transform.position;
                    parent.gameObject.GetComponentsInChildren<TextMesh>()[(i * nCols) + j].text = artistsToBuy[(i * nCols) + j].name + "\n" + artistsToBuy[(i * nCols) + j].price + "$";
                    //    Debug.Log(parent.gameObject.GetComponentsInChildren<TextMesh>()[(i * nCols) + j].transform);

                }
            }
        }
    }


}