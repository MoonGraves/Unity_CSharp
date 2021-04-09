using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    //SerializeField - niin kuin antaa unity määritettyn objektin päähenkilö tehdä jotakin liikkuvuutta asetuksissa,
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    //TOI YKSI OBJEKTI MIKÄ PYÖRII 360 astetta
    // Update is called once per frame
    void Update()
    {   
        //Asteikkon akseli xyz
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
