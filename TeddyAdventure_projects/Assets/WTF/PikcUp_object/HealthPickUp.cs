using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    //NOSTA ENSIAPU PAKETTIN JA LISÄÄ HEALTh JA JNE & SAMA KUIN PICK UP AMMO TYYPPINEN 
    //PICK UP HEALTH AND ADD TO PLAYER HEALTH FOR SURIVAL LONGER

    [SerializeField] float healthValue = 15f;
    [SerializeField] PlayerHealth playerHP;  //Lukaisee ensin tiedoston ja mitäkin tekijänssä

    void Awake()
    {
        playerHP = FindObjectOfType<PlayerHealth>();
    }
     
    //PELAAJA PICKUP ENSIAPU PAKETIN & HETI SAMANTIEN OTTAA SEN KÄYTTÖÖN
    //VAIKKA PELAAJALLA OLISIKIN MAKSIMI HEALTH: 100, SITÄ VOIDAAN KUITENKIN YLITTÄÄ SEN
    private void OnTriggerEnter(Collider other) 
    {
        if( playerHP.currentHealth < playerHP.hitPoints && other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Pick up health");
            playerHP.hitPoints += healthValue;
        }
    }
    
}
