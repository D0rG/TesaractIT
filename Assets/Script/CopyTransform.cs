using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyTransform : MonoBehaviour
{
    public Transform[] clones;
    Vector3[] offsets;

    // Start is called before the first frame update
    void Start()
    {
        offsets = new Vector3[clones.Length];
        for (int i = 0; i <= clones.Length; i++)
        {
            offsets[i] = clones[i].position - transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= clones.Length; i++)
        {
            clones[i].position = offsets[i] + transform.position;
            clones[i].rotation = transform.rotation;
            clones[i].localScale = transform.localScale;
        }
    }
}
