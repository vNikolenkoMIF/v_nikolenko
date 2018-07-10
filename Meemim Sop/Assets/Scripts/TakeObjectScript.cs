using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TakeObjectScript : MonoBehaviour, IInputHandler {

    public GameObject RightHand;

    GameObject[] Cones;

    GameObject Cone;


    

    public void OnInputDown(InputEventData eventData)
    {
        

        if (!eventData.used)
        {
            if (Physics.Raycast(
               Camera.main.transform.position,
               Camera.main.transform.forward,
               10.0f,
               Physics.DefaultRaycastLayers) )
            {
                Cone = GameObject.FindGameObjectWithTag("Cone");

                Cone.transform.position = transform.TransformDirection(RightHand.transform.position.x, 0f , RightHand.transform.position.z);
            }
        }
    }

    public void OnInputUp(InputEventData eventData)
    {

        if (eventData.used)
        {
            eventData.Use();
            if (Physics.Raycast(
               Camera.main.transform.position,
               Camera.main.transform.forward,               
               10.0f,
               Physics.DefaultRaycastLayers) )
            {
                Cone = GameObject.FindGameObjectWithTag("Cone");

                Cone.transform.position = RightHand.transform.position;
            }
                        
        }

    }

}
