using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //TIPPUVA KUUTIO / PALIKKA / OBJEKTI
    /*Debug.Log() sama kuin Console.WriteLine("Blah")*/

    //Kun käyttäjä aktivoi pelin, tippuva palikka muuttuu kiinteäksi 2 sekunnin jälkeen, ennen sitä se oli vain näkymätön

    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f; //määritys aika pari tai muutamaksi sekunniksi

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent <MeshRenderer>();
        rigidbody = GetComponent <Rigidbody>();

        renderer.enabled = false; //on näkymätön
        rigidbody.useGravity = false; //ei tiputta sitä putoamiskiihtyvyttä
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time); //tulostaa joka sekuntti
        if(Time.time > timeToWait )
        {
            //Debug.Log("3 sekuntti elapsed"); //toistuu jatkuvasti, heti aktivoitu peliä
            renderer.enabled = true; //on näkymätön
            rigidbody.useGravity = true; //ei tiputta sitä putoamiskiihtyvyttä
        }
    }
}
