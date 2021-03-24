using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //ONLY FOR WALL OF PIECES & 
    /*Debug.Log() sama kuin Console.WriteLine("Blah")*/
    private void OnCollisionEnter(Collision other) 
    {
        if ( other.gameObject.tag == "Player") 
        {

        GetComponent<MeshRenderer>().material.color = Color.cyan; //joka kerta kun käyttäjä törmää johonkin muuttuu toisenlaiseksi väriksi & cyan vaaleasininen
            gameObject.tag = "Hit"; //osuu mikäkin palikkaan muuttaa sen tag > hittiksi
        }
    }
}
