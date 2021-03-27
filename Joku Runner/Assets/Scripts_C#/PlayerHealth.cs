using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    //PELAAJAN HEALTH 
    [SerializeField] float hitPoints = 100f; //PELAAJAN hitpoint on ton verran & sitä voi muuttaakin

    [SerializeField] TextMeshProUGUI healthText; 

    //joku method which reduces hitpoints by the amont of damage & damage methodi

    public void TakeDamage(float damage)
    {
        DisplayHealth();

        hitPoints -= damage;
        if (hitPoints <= 0) 
        {
            //Debug.Log("You dead, my glip glop");
            GetComponent<DeathHandler>().HandleDeath(); //lukaisee DeathHandler.cs tiedoston
        }
        
    }

    void Update() 
    {
        DisplayHealth();
    }

    public void DisplayHealth()
    {
        float currentHealth = hitPoints;
        healthText.text = currentHealth.ToString();
    }

}
