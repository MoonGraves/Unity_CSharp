using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    //ASEEN LUOTTI MÄÄRÄ & AMMO PAIKKA, JOKAISEESSA ASEESSA TAI TIETYISSÄ ASEESSA & CLASS
    //[SerializeField] int ammoAmount = 20;

    [SerializeField] AmmoSlot[] ammoSlots;


    //sama kuin tavallinen SerializeField & MUTTA MOLEMMAT OVAT ERI tekijöitä
    [System.Serializable]

    //privaatti class 
    private class AmmoSlot
    {
        public AmmoType ammoType;
        public int ammoAmount;
    }

    public int GetCurrentAmmo(AmmoType ammoType)
    {
        return GetAmmoSlot(ammoType).ammoAmount;
    }

    //LUOTI AMMO VÄHENEE KOKOAJAN
    public void ReduceCurrentAmmo(AmmoType ammoType)
    {
        GetAmmoSlot(ammoType).ammoAmount--;
    }

    //ADD AMMO FROM PICKUP OBJECTS & Lisätään nostettun objektin summan määrän mukaan, että lisätään ammoa siihen pakettin sisään
    public void IncreaseCurrentAmmo(AmmoType ammoType, int ammoAmount)
    {
        GetAmmoSlot(ammoType).ammoAmount += ammoAmount;
    }

    private AmmoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach(AmmoSlot slot in ammoSlots)
        {

            if (slot.ammoType == ammoType)
            {
                return slot;
            }

        }

        return null;
    }
    
}
