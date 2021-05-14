using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInHamdTeleportation : MonoBehaviour
{
    ControllerManagerSample hands;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        hands = GetComponentInChildren<ControllerManagerSample>();
        if (hands != null) Debug.Log("Find");
        else Debug.Log("notFind");
    }
}
