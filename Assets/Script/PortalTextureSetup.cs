using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    public Camera mainL;
    public Camera mainR;
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

            //cameras[i].targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            cameras[i].targetTexture = new RenderTexture(mainL.pixelWidth, mainL.pixelHeight, 24);


            camerasMats[i].mainTexture = cameras[i].targetTexture;
            camerasMats[i].SetFloat("_K", mainL.aspect / cameras[i].aspect);
            if (cameras[i].stereoTargetEye == StereoTargetEyeMask.Left)
            {

                camerasMats[i].SetFloat("_Add", 0.45f );
            }
            else camerasMats[i].SetFloat("_Add", 0.55f );
        }
    }

}
