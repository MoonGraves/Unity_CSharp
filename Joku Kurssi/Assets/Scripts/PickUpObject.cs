using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    //Nostaa objektin >> https://www.youtube.com/watch?v=qD7fDop-Ptw
    void OnTriggerEnter(Collider collider) 
    {
        if(collider.gameObject.tag == "Player" ) 
        {
            Debug.Log("Nosta tuote");
            Destroy(gameObject);
        }
    }
}
