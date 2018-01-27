using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyArtist : MonoBehaviour {

    List<Artists> artistsToBuy = Artists.allArtists;
    public static bool LastOperationWorked;
    public void buyArtist()
    {
        foreach (Artists artist in artistsToBuy)
        {
            Debug.Log(this.name);
            if (this.name == artist.id.ToString())
            {
                RadioStation radioStation = RadioStation.allStations[0];
                if (artist.price > radioStation.balance)
                {
                    Debug.Log("Not enougth money");
                    LastOperationWorked = false;
                }
                else
                {
                    LastOperationWorked = true;
                    radioStation.balance -= artist.price;
                    Debug.Log(radioStation.balance);
                }
            }
        }
    }
}
