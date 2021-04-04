using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjectRotation : MonoBehaviour
{
    //THIS IS ONLY FOR OBJECT ROTATION FILES
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //typerät aksletit (XYZ)
        transform.Rotate(new Vector3(0f, 20f, 0f) * Time.deltaTime);
    }
}
