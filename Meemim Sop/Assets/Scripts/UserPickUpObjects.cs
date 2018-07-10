using UnityEngine;

public class UserPickUpObjects : MonoBehaviour {

    public Transform WrenchObject;

    public Transform RightHandPosition;

    public Rigidbody joystickRigidbody;

    private void Update()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(
                Camera.main.transform.position,
                Camera.main.transform.forward,
                out hitInfo,
                20.0f,
                Physics.DefaultRaycastLayers))
        {

            WrenchObject.transform.position = RightHandPosition.transform.position;

            joystickRigidbody.freezeRotation = true;
            // If the Raycast has succeeded and hit a hologram
            // hitInfo's point represents the position being gazed at
            // hitInfo's collider GameObject represents the hologram being gazed at
        }
    }
}
