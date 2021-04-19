using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectHint : MonoBehaviour
{
    //TÄMÄ ON JOKIN OBJEKTI VINKKI TAI JOKIN ILMOITUS UI - PANEL VARTEN
    //ESIM PELAJAA KOSKEE TAI KERÄÄ JOTAKIN OBJEKTIA, ILMOITUS ESIINTYY PELIN RUUDUN NÄKYVILLE
    
    public GameObject uiObject;
    public GameObject cube;

    //tähän tulee se tietty canvas tai panel
    public static bool ObjectTrigger = false;
    public GameObject ObjectTriggerUI;
    
    //
    private bool HintEnabled;
 
    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            uiObject.SetActive(true);
                Debug.Log("Hint the object");
            //Destroy(gameObject);
        }
    }

    //Kun pelaaja poistuu siitä kuution alueesta, niin panel ei aktivoidu enää
    void OnTriggerExit(Collider other) 
    {
        uiObject.SetActive(false);
        Destroy(cube); // tuhoo objektin, kun pelaaja on nostanut sen
    }

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false); //kerätäv object avaa panel tekstin
    }


    // Update is called once per frame
    public void Update()
    {
        
    }
}
