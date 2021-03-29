using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    //PELAAJAN HEALTH & UI PELAAJAN HEALTH MÄÄRÄ, ENNEN KUIN TULEE GAME OVER
    public float hitPoints = 100f; //PELAAJAN hitpoint on ton verran & sitä voi muuttaakin & MAKSIMI HEALTH MÄÄRÄ
    public float currentHealth; //TÄLLÄ HETKELLÄ MITEN PALJO ON HEALTH JÄLJELLÄ & OISKI ENEMMY HITTANNUT PELAAJAAN

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

    ////////////////////////////////////////////
    //UPDATE DISPLAY THE PLAYER HEALTH VALUE LEFT
    void Update() 
    {
        DisplayHealth();
    }

    //PELISSÄ MÄÄRITETTY ESIM. 100HP , JOKA KERTA KUN ENEMY ISKEE PELAJAAN NIIN PALJON ON JÄLJELLÄ HP RUUDUSSA
    public void DisplayHealth()
    {
        float currentHealth = hitPoints;
        healthText.text = currentHealth.ToString();
    }

}
