using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInfo : MonoBehaviour
{
    Camera self;
    float aspect;
    Rect rect;
    public Camera main;
    float cameraWidth;
    float cameraHeight;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Camera>();
        aspect = main.aspect;
        rect = main.pixelRect;
        cameraHeight = main.pixelHeight;
        cameraWidth = main.pixelWidth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("name " + self.name + "aspect " + self.aspect+ " focalLength " + self.focalLength+  " ixelHeight " + self.pixelHeight+ " pixelWidth " + self.pixelWidth+ " scaledPixelHeight " + self.scaledPixelHeight+ " scaledPixelWidth " + self.scaledPixelWidth+ " sensorSize " + self.sensorSize+ " stereoConvergence " + self.stereoConvergence+ " stereoSeparation " + self.stereoSeparation+" rect "+ self.rect);
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            float x = (100f - 100f / (Screen.width / cameraWidth)) / 100f;
            float y = (100f - 100f / (Screen.height / cameraHeight)) / 100f;
            //self.rect = new Rect((Screen.width - 512.0f) / Screen.width, (Screen.height - 256.0f) / Screen.height, 384.0f / Screen.width, 96.0f / Screen.height);
            self.aspect = aspect;
            self.pixelRect = rect; 
        }
    }
}
