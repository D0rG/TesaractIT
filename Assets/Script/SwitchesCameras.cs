using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesCameras : MonoBehaviour
{
    public Transform switcher;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, switcher.position-transform.position);
        RaycastHit raycastHit;
        if (Physics.Raycast(ray,out raycastHit))
        {
            if (raycastHit.collider.transform.tag == "switchCamera")
            {
                GetComponent<Camera>().enabled=true;
            }
            else GetComponent<Camera>().enabled = false;
        }
        else GetComponent<Camera>().enabled = false;
    }
}
