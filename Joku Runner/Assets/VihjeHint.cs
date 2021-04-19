using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VihjeHint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other) 
    {
        switch(other.gameObject.tag)
        {
            case "Hint" :
                Debug.Log("Kerräsit vihjeen boxin");
            //OpenHintBox();
                break;
            
            case "Item":
                Debug.Log("Kerräsit itemin");
                break;
            
            default:
                Debug.Log("Kerräsit jotakin muuta");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
