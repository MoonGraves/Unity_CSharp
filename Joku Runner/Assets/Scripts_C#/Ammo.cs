using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    //ASEEN LUOTTI MÄÄRÄ   JOKAISEESSA ASEESSA TAI TIETYISSÄ ASEESSA & CLASS
    [SerializeField] int ammoAmount = 20;

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }

    //LUOTI AMMO VÄHENEE KOKOAJAN
    public void ReduceCurrentAmmo()
    {
        ammoAmount--;
    }
}
