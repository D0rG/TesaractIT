using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Lazer>().enabled) GetComponent<Lazer>().enabled = true;
    }
}
