using UnityEngine;
using System.Collections;

public class doorButton : MonoBehaviour {

    GameObject door;
    GameObject buttonColl;
    SF_doorControl doorControl;
    float pressDist = 0.05f;

    void Start () {
        door = GameObject.FindGameObjectWithTag("Door");
        buttonColl = GameObject.Find("ButtonCollider");
        doorControl = door.GetComponent<SF_doorControl>();
    }
    
    void OnTriggerEnter (Collider other) {
        buttonColl.transform.position += Vector3.back * pressDist;
        transform.position += Vector3.forward * pressDist;
        if (!doorControl.isDoorOpen())
        {
            doorControl.openDoor();
        }
        else
        {
            doorControl.closeDoor();
        }
    }

    void OnTriggerExit (Collider other)
    {
        buttonColl.transform.position -= Vector3.back * pressDist;
        transform.position -= Vector3.forward * pressDist;
    }

}
