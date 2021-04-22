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
    

    //teksti [F] teke jotakin
    public GameObject HintText;

    //Pelaaja koskee collider alueeseen
    private void OnTriggerEnter(Collider other2) 
    {
        HintText.SetActive(true);
    }
 
    public void OnTriggerStay(Collider other) 
    {
        
        this.gameObject.GetComponent<ObjectHint>().enabled = true;
        if ((other.tag == "Player") && Input.GetKeyDown(KeyCode.F))
        {
            uiObject.SetActive(true);
            HintText.SetActive(false);
            Debug.Log("Hint the object");
            //Destroy(gameObject);
        }

        /*switch(other.gameObject.tag)
        {    
            case "Hint" :
                Debug.Log("Avaa hint?");
                break;
        }*/

    }

    //Kun pelaaja poistuu siitä kuution alueesta, niin panel ei aktivoidu enää
    void OnTriggerExit(Collider other) 
    {
        this.gameObject.GetComponent<ObjectHint>().enabled = false;
        uiObject.SetActive(false); //ui panel
        HintText.SetActive(false); //ui teksti mikä on keskellä että [F] Open Panel
        //Destroy(cube); // tuhoo objektin, kun pelaaja on nostanut sen
    }

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false); //kerättäv object avaa panel tekstin
        HintText.SetActive(false); //ui teksti mikä on keskellä että [F] Open Panel
    }


    // Update is called once per frame
    public void Update()
    {
        
    }
}
