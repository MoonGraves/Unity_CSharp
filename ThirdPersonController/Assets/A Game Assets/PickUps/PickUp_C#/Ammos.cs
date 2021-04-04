using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammos : MonoBehaviour
{
    //ASEEN LUOTTI MÄÄRÄ & AMMO PAIKKA, JOKAISEESSA ASEESSA TAI TIETYISSÄ ASEESSA & CLASS
    //[SerializeField] int ammoAmount = 20;

    [SerializeField] AmmoSlot[] ammoSlots;


    //sama kuin tavallinen SerializeField & MUTTA MOLEMMAT OVAT ERI tekijöitä
    [System.Serializable]

    //privaatti class 
    private class AmmoSlot
    {
        public AmmoTypes ammoTypes;
        public int ammoAmount;
    }

    public int GetCurrentAmmo(AmmoTypes ammoTypes)
    {
        return GetAmmoSlot(ammoTypes).ammoAmount;
    }

    //LUOTI AMMO VÄHENEE KOKOAJAN
    public void ReduceCurrentAmmo(AmmoTypes ammoTypes)
    {
        GetAmmoSlot(ammoTypes).ammoAmount--;
    }

    //ADD AMMO FROM PICKUP OBJECTS & Lisätään nostettun objektin summan määrän mukaan, että lisätään ammoa siihen pakettin sisään
    public void IncreaseCurrentAmmo(AmmoTypes ammoType, int ammoAmount)
    {
        GetAmmoSlot(ammoType).ammoAmount += ammoAmount;
    }

    private AmmoSlot GetAmmoSlot(AmmoTypes ammoTypes)
    {
        foreach(AmmoSlot slot in ammoSlots)
        {

            if (slot.ammoTypes == ammoTypes)
            {
                return slot;
            }

        }

        return null;
    }
    
}
