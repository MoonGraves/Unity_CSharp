using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControls : MonoBehaviour
{
    //Boss liikkuvuus vasemmasta oikealle
    //public float min = 2f;
    //public float max = 3f;

    //
    
     
    public float movementSpeed = 0.04f;
 
    private Rigidbody rb;
    private Vector3 endPosition = new Vector3(0, 3, 0);

    // Start is called before the first frame update
    void Start()
    {
        //min = transform.position.x;
        //max = transform.position.x+3;
                rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
        if(transform.position != endPosition) {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
        }
    }
}
