using HoloToolkit.Unity.Buttons;
using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject informCanvas;

    public GameObject secondInformCanvas;

    public GameObject Arrow;

    public GameObject TeleportPoint;


    public void Start()
    {
        TeleportPoint.SetActive(false);

        Arrow.SetActive(false);
    }

    public void OnInputClicked()
    {
        informCanvas.SetActive (false);

        if (!informCanvas.activeSelf)
        {           
            secondInformCanvas.SetActive(true);

            Arrow.SetActive(true);

            TeleportPoint.SetActive(true);
        }

    }
}
