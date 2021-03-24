using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    //PISTEEN KERÄÄMINEN

    int hits = 0;

    private void OnCollisionEnter(Collision other) 
    {
        //Jos on osunut kerran yhen palikkan / objektiin, nii ei ovi enää kerrää samaa x materiaalin pistettä 
        if(other.gameObject.tag != "Hit" ) 
        {
            hits++;
            Debug.Log("You've dumped into a thing this many times!!" + hits);
        }
    } 
    
}
