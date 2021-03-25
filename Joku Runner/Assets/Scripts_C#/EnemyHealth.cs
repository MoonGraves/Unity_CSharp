using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //VASTUSTAJAN / ENEMY HEALTH
    [SerializeField] float hitPoints = 100f; //ENEMY hitpoint on ton verran & sitä voi muuttaakin 

    //joku method which reduces hitpoints by the amont of damage & damage methodi

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0) 
        {
            Destroy(gameObject);
        }
    }

}
