using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //SerializeField - niin kuin antaa unity määritettyn objektin päähenkilö tehdä jotakin liikkuvuutta asetuksissa,
    //että siellä käyttöliittymässä voidaan määrittää jokin akseli liikkuvuus & 
    //[SerializeField] float yValue = 0.02f;

    [SerializeField ]float moveSpeed = 10f;

    // Start is called before the first frame update & funktio/methodi jotakin alkuun & alku heti kun käynnistät pelin
    //Debug.Log(); sama kuin chsarp Console.writeline("blah blah");
    void Start()
    {   
        Debug.Log("Welcome to the Game!");
        PrintInstructions(); //tulostaa niitä viestiä
    }

    // Update is called once per frame & päivitystä methodi
    void Update()
    {
        //akselit xyz - suunnan mukaan, f=float, ei ymmärrä 0.01 
        //transform.Translate(0.01f, 0f, 0f);
 
        //transform.Translate(xValue, yValue, zValue); //liikkuu itsekseen kohti xyz akselin mukaan, mitä alussa määritetty esim. menee itsekseen

        MovePlayer(); 
    }

    //uusi methodi
    void PrintInstructions()
    {
        Debug.Log("Speedy liikkuu joohonkin!");
        Debug.Log("Liikku nuoli näppäimen mukaan!");
    }

    //Käyttäjä liikkuu
    void MovePlayer()
    {
        //Slow pc fps 10 duration of frames 0.1 =>> 1 x 10 x 0.1 = 1
        //fast pc fps 100 duration of frams 0.01 =>> 1 x 100 x 0.01 = 1

        //Määrittään palikka/käyttäjä liikkumis nopeus
        float xValue = Input.GetAxis("Horizontal") *Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") *Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue); //keyboard (vasen/oikea & ylös ja alas)
    }


}
