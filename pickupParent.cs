using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class pickupParent : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

	}
	
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);

        if(device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You are touching down the trigger.");
        }

        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated 'TouchDown'.");
        }

        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated 'TouchUp'.");
        }

        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You are holding 'Press' on the trigger.");
        }

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated 'PressDown'.");
        }

        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("You have activated 'PressUp'.");
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("You have collided with " + coll.name + " and activated OnTriggerStay()");
    }
}
