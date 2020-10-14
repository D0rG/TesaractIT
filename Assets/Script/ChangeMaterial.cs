using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material mat;
    public Camera main;
     Camera self;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Camera>();
        mat.SetFloat("_K",main.aspect/self.aspect);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            mat.SetFloat("_K", main.aspect / self.aspect);
            mat.SetFloat("_Add", 0.5f-self.stereoSeparation);

            
        }
    }
}
