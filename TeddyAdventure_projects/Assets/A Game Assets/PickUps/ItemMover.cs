using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMover : MonoBehaviour
{

   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


     void Update()
     {
         
        float xValue = 0.0F;
        float yValue = 0.0F;
        float zValue = 0.0002F * (1 / Time.deltaTime);
         transform.Rotate(xValue,yValue,zValue);


         // ALLA OLEVA EI TOIMI PRKL
   //     float speed = 6f;
     //     float y = Mathf.PingPong(speed, 1.6f) ;
     //     transform.position = new Vector3(0, y, 0.2f);
     }
}
