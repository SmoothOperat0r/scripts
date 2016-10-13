using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    private SteamVR_Controller.Device Controller;
    SteamVR_TrackedObject trackedObj;

    // Use this for initialization
    void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        Controller = SteamVR_Controller.Input((int)trackedObj.index);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("The controller is touching " + other.name);
    }
    
}
