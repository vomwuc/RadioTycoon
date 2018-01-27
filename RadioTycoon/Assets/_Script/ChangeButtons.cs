using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtons : MonoBehaviour
{

    public GameObject enableButton;
    public GameObject disableButton;
    public DrawAnimation drawAnimation;

    public void SwitchButton()
    {
        enableButton.SetActive(!enableButton.activeSelf);
        disableButton.SetActive(!disableButton.activeSelf);
    }

    public void changeOtherIneterractButtons()//(bool me , bool others)
    {
        Transform[] trs = this.transform.parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.gameObject.GetComponent<Button>() != null && this.transform != t.parent)
            {
                t.gameObject.GetComponent<Button>().interactable = !t.gameObject.GetComponent<Button>().IsInteractable();
                drawAnimation.draw = t.gameObject.GetComponent<Button>().interactable;
            }
        }
    }

    public void changeComercialStatus()
    {
        RadioStation.allStations[0].isComercial = !RadioStation.allStations[0].isComercial;
    }

}
