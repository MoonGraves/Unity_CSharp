using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveACar1 : MonoBehaviour
{

    public Rigidbody rb;
    public Transform car;
    public float speed = 17;


    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Move a car");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Auton liikkuminen & tai muu
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(backward * speed * Time.deltaTime);
        }
    }   
}
