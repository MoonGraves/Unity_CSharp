using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{


// TÄHÄN TIEDOSTOON KAIKKI MUUTTUJAT!
public static Player_Stats instance;

// PLAYER STATS
public int hitPoints;
// VIhollisesta tulee sen tuhoutuessa
// Player_Stats.instance.PlayerExperience += 5;
public int PlayerExperience;

// tätä säädetään myöhemmin, joku saa myös tehdä halutessaan
public int playerLevel;

public int secretToken;

// nämä arvot lisääntyvät kun objekteja kerätään kentältä, ja ne myös vähenevät, jos niitä käytetään samalla periaatteella
//Player_Stats.instance.hitPoints += 50; tai Player_Stats.instance.hitPoints -= 50;
public int pistolAmmo;
public int rocketAmmo;

public int playerDamage;


// Weapons
public bool Nuppineula = false;

// Quest Items
public bool airVentOpener = false;


     void Start () {
         instance = this;


        // se miten HP arvo tuodaan aluksi, on vielä vähän auki, testatataan tätä.
         if(hitPoints == 0){
         hitPoints += 100;
         }
     if(playerDamage == 0){
         playerDamage += 25;
         }

     }
}


