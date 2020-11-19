using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopeJoyStick : MonoBehaviour
{
    public Dictionary<string, Clone> clones = new Dictionary<string, Clone>(0);
    public struct Clone
    {
        public Transform transf;
        public Vector3 offsets;

        public Clone (Transform newTransf, Vector3 newOffset)
        {
            transf = newTransf;
            offsets = newOffset;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (KeyValuePair<string, Clone> clone in clones)
        {
            clone.Value.transf.position = transform.position + clone.Value.offsets;
        }
    }
}
