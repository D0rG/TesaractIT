using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform pointSpawn;
    public Transform pointVector;
    public Transform room;
    public GameObject lazer;
    public Transform teleport;
    public void Spawn()
    {
        pointSpawn.LookAt(pointVector);
        Vector3 angle = pointSpawn.eulerAngles;
        Quaternion q = Quaternion.Euler(angle);
        GameObject trash = Instantiate(lazer, pointSpawn.position, q,room);
        trash.transform.LookAt(teleport);
        trash.transform.eulerAngles += new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        //trash.transform.eulerAngles=angle;
        trash.GetComponent<Lazer>().number = 1;
        trash.GetComponent<Lazer>().active = true;
    }
    
}
