using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButtonClick : MonoBehaviour {

    public GameObject secondCanvas;

    public TapTeleportation tapTeleportation;

    public GameObject Arrow;

    private void Update()
    {
        if (tapTeleportation.TeleportCompleted)
        {
            OnClick();
        }
    }


    public void OnClick()
    {
        secondCanvas.SetActive(false);

        Arrow.SetActive(false);        

    }



    // Update is called once per frame

}
