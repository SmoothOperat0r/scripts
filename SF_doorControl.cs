using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SF_doorControl : MonoBehaviour {

    private bool isOpen = false;
    private Animation anim;
    private Color appear;
	
	void Start () {
        anim = GetComponent<Animation>();
        appear = transform.parent.GetComponentInChildren<Text>().color;
    }

    public void openDoor()
    {
        if (!anim.isPlaying)
        {
            anim.Play("open");
            isOpen = true;
        }
        
    }

    public void closeDoor()
    {
        if (!anim.isPlaying)
        {
            anim.Play("close");
            isOpen = false;
        }
    }

    public bool isDoorOpen()
    {
        return isOpen;
    }
}
