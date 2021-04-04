using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    //NOSTA PATRUUNAT JA LISÄÄ ASESIIN LUOTIT JA JNE
    //PICK UP AMMO AND ADD TO WEAPONS FOR SURIVAL LONGER

    //ADD AMMO TO PLAYER WEAPONS + FOR AMMO TYPE 
    [SerializeField] int ammoAmount = 0; //TODO lisää tää sinne pilviin
    [SerializeField] AmmoType ammoType; //Shell, Bullet, Rockets
    
    void Update() 
    {
        //akseli rotaation ( xyz )
        //gameObject.transform.Rotate(new Vector3(0f, 50f, 0f) * Time.deltaTime);
    }

    //MUISTA MÄÄRITTÄÄ ITSE PELAAJA TAG >> Player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            Debug.Log("Player pick up something usefull");

            FindObjectOfType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject); //Kun pelaja on nostanut objektin niin se kattoo
        }
    }

}
