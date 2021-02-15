using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraberHolderIndification : MonoBehaviour
{
    // Start is called before the first frame update
    public string nameId = "";
    public string controllerNameID = "";
    public void Grab()
    {
        nameId = controllerNameID;
    }
    public void Release()
    {
        nameId = "";
    }
    public void OnTriggerEnter(Collider other)
    {
        var coll = other.gameObject.GetComponent<ControllerColliderName>();
        if (coll != null)
        {
            controllerNameID = coll.nameId;
        }
    }
}
