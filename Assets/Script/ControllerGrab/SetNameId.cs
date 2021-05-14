using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNameId : MonoBehaviour
{
    public string nameId = "Player1";
    void Start()
    {
        ControllerColliderName[] childColl = GetComponentsInChildren<ControllerColliderName>();
        foreach (ControllerColliderName children in childColl)
        {
            children.nameId = nameId;
        }
    }

    public void Teleport(Vector3 start, Vector3 end, Quaternion rot)
    {
        var holdObjects = FindObjectsOfType<GraberHolderIndification>();
        foreach (var obj in holdObjects)
        {
            Debug.Log(obj.nameId + " compare " + nameId);
            if (obj.nameId == nameId)
            {
                
                var grabber = obj.gameObject.GetComponent<BasicGrabbable>();
                Debug.Log("new pos rot"+grabber.pos + " " + end + " " + start + " " + (grabber.pos - end + start));
                grabber.enabled = false;
                grabber.enabled = true;//try change thaaaaat
                //grabber.pos = grabber.pos - end + start;
                //grabber.rot = rot;
               // grabber.isTeleport = true;
                //gameObject.GetComponent<PortalTraveller>().enabled = false;
                //grabber.OnColliderEventDragEnd(grabber.lastJoy);
                // grabber.ClearEventGrabberSet();
                //grabber.gameObject.transform.position =  - end + start;
            }
        }
    }

}
