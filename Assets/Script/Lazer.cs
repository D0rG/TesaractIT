using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float speed;
    public int number = 5;
    public Transform back;
    public bool active;
    public float life=1000;
    public Vector3 offsetLeft;
    public Vector3 offsetRight;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
        if (other.tag == "bulletPortal")
        {
            //Debug.Log("portal");
            transform.parent = null;
            transform.position = transform.position - offsetLeft;
            GameObject trash = Instantiate(gameObject,transform.position -offsetRight,transform.rotation);
        }
        else if ((other.tag != "Lazer")&&(other.tag!= "Tesaract"))
        {
            //Debug.Log(other.tag);
            GameObject.Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (active)
        {
            if (number > 0)
                    {
                        GameObject trash = Instantiate(gameObject, back.position, transform.rotation);
                        trash.GetComponent<Lazer>().number = number - 1;
                        trash.GetComponent<Lazer>().active = true;
                trash.transform.parent = transform.parent;
                    }
            active = false;
        }
        
        else GetComponent<Rigidbody>().velocity=(transform.forward*speed*Time.deltaTime);
        life = life - Mathf.Abs( speed * Time.deltaTime);
        if (life < 0) GameObject.Destroy(gameObject);
    }
    void FixedUpdate()
    {
        if (active)
        {
           
        }

        else GetComponent<Rigidbody>().velocity = (transform.forward * speed);
    }
}
