using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdButtonClick : MonoBehaviour {

    public GameObject thirdPanel;

    public GameObject progressSlider;

    public GameObject fourthPanel;

    public GameObject coneMarker;


    public void DisabledPanel()
    {
        if (progressSlider.activeSelf)
        {
            thirdPanel.SetActive(false);

            progressSlider.SetActive(false);

            coneMarker.SetActive(true);

            fourthPanel.SetActive(true);
        }
    }
}
