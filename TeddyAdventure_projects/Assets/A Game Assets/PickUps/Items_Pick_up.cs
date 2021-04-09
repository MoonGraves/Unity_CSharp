using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items_Pick_up : MonoBehaviour
{

   public Player_Stats playerstats;
void start(){

}
 void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        { 
            case "xAmmoPistol":
                Debug.Log("pistooli panoksia kerätty");
                 Destroy(other.gameObject);
                 Player_Stats.instance.pistolAmmo += 5;
                break;

            case "xAmmoRocket":
                Debug.Log("Rocket panoksia kerätty");
                Player_Stats.instance.rocketAmmo += 1;
                 Destroy(other.gameObject);

                break;

             case "xSHealth":
                Debug.Log("Small Health");
                Player_Stats.instance.hitPoints += 25;
                 Destroy(other.gameObject);

                break;

             case "xBHealth":
                Debug.Log("Big Health");
                Player_Stats.instance.hitPoints += 50;
                 Destroy(other.gameObject);
                break;

             case "WNuppineula":
                Debug.Log("ENSIMMÄINEN SE NUPPINEULA KERÄTTY");
                Player_Stats.instance.Nuppineula = true;
                Destroy(other.gameObject);
                break;
                
             case "secretToken":
                
                Player_Stats.instance.secretToken += 1;
                Debug.Log("Secret Token Kerätty yht: " + Player_Stats.instance.secretToken );
                Destroy(other.gameObject);
                break;

            default:
                Debug.Log("Osuttu Johonkin");
                break;
        }
    }




}


