using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    //USER/PELAAJA VAIHTAA ASEEN

    [SerializeField] int currentWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetWeaponActive();
    }

    // Update is called once per frame
    void Update()
    {
        //Edellinen ase
        int previousWeapon = currentWeapon;

        ProcessKeyInput();
        ProcessScrollWheel(); //hiiren rulla

        if(previousWeapon != currentWeapon )
        {
            SetWeaponActive();
        }
    }

    //PLAYER MOUSE SCROLLER
    private void ProcessScrollWheel()
    {
        //IF GOING UP & SCROLLAA HIIREN KOHTI ETEENPÄIN/YLÖS
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentWeapon >= transform.childCount - 1)
            {
                currentWeapon = 0;
            }

            else
            {
                currentWeapon++;
            }
        }

        //IF GOING DOWN & SCROLLAA HIIREN KOHTI ETEENPÄIN/ALAS
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currentWeapon <= 0)
            {
                currentWeapon = transform.childCount -1;
            }
            
            else
            {
                currentWeapon--;
            }
        }

    }

    //KEYBOARD NUMBER CHANGE WEAPONS
    private void ProcessKeyInput()
    {   
        //keyboard 1 eka rynkky
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            currentWeapon = 0; //asettaa asen 0
        }

        //Keyboard 2 pistooli
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            currentWeapon = 1; //asettaa asen 1 
        }

        //Keyboard 3 shotgun
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2; //asettaa asen 2
        }
    }

    //Valitse aseesi
    void SetWeaponActive()
    {
        int weaponIndex = 0; //Pistooli 1, eka ase 0, shotgun 2,
        foreach (Transform weapon in transform) 
        {
            if ( weaponIndex == currentWeapon )
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }

    }

}
