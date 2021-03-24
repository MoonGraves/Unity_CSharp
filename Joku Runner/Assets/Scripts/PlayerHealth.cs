using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
[SerializeField] float hitPoints = 100f; //ENEMY hit point on ton veran

    //joku method which reduces hitpoints by the amont of damage & damage methodi

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0) 
        {
            Debug.Log("You dead, my glip glop");
        }
    }

}
