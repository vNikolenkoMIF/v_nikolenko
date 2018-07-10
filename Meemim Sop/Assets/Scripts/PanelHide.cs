using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHide : MonoBehaviour {

    public GameObject informPanel;

    public Transform cameraPosition;

    public Transform panelPosition;



    public float minDistance = 3f;

    // Update is called once per frame
    private void Update()
    {


        if (Vector3.Distance(cameraPosition.transform.position, panelPosition.transform.position) < minDistance)
        {
            informPanel.SetActive(false);
        }
    }

}
