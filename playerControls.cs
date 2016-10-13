using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;
    private bool touchingPortal = false;
    private int position;

    // Use this for initialization
    void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

        controller.TriggerHapticPulse(1000);
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null) {
            Debug.Log("Controller not initialized");
            return;
        }

        if (controller.GetPressDown(triggerButton) && touchingPortal) {
            Debug.Log("Trigger is pressed on something.");
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entering Trigger");
        touchingPortal = true;
        controller.TriggerHapticPulse(1000);
    }

    // Remove all items no longer colliding with to avoid further processing
    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("Exiting Trigger");
        touchingPortal = false;
    }
}
