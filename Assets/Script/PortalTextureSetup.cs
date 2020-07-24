using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{

    public Camera[] cameras;

    public Material[] camerasMats;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i].targetTexture != null)
            {
                cameras[i].targetTexture.Release();
            }

            cameras[i].targetTexture = new RenderTexture(Screen.width, Screen.height, 24);


            camerasMats[i].mainTexture = cameras[i].targetTexture;
        }
    }
        
    
}
