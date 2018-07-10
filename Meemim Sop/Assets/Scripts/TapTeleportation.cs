using HoloToolkit.Examples.InteractiveElements;
using HoloToolkit.Examples.Prototyping;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.UX.Progress;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTeleportation : MonoBehaviour, IInputClickHandler,IFocusable
{
    public GameObject userGameObject;

    public GameObject teleportPoint;

    public GameObject cursorPosition;

    public GameObject thirdPanel;

    public GameObject sliderKnob;

    public GameObject progressSlider;




    bool InFocus;

    public float minDistance;

    public bool TeleportCompleted;


    public void OnFocusEnter()
    {
        InFocus = true;
    }

    public void OnFocusExit()
    {
        InFocus = false;
    }


    public void OnInputClicked(InputClickedEventData eventData)
    {
        RaycastHit hitInfo;


        if (Physics.Raycast(
                Camera.main.transform.position,
               Camera.main.transform.forward,
                out hitInfo,
               minDistance,
                Physics.DefaultRaycastLayers) && InFocus)
        {
            Vector3 newPosition = new Vector3(teleportPoint.transform.position.x, userGameObject.transform.position.y, teleportPoint.transform.position.z);
            
            userGameObject.transform.position = newPosition;

            TeleportCompleted = true;

            eventData.Use();


            if (TeleportCompleted)
            {
                thirdPanel.SetActive(true);

                progressSlider.SetActive(true);

                sliderKnob.transform.position = new Vector3(sliderKnob.transform.position.x + 0.3f, sliderKnob.transform.position.y, sliderKnob.transform.position.z);
            }
        }
    }

   

}
