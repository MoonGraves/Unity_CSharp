using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //TÄMÄ ON PELAAJAN HEALTH BAR UI CANVAS & JOKA KERTA JOS ON UI EDITOINTI VASTAAVA LISÄÄ AINA KÄYTÖSSÄ ON:: using UnityEngine.UI;
    /* UI editoinnissa pitää olla tarkanna, että mikä tule järjestykesssä, koska esim. takan tausta on jokin väri, etumaisessa pitää olla pelaajan HP
    sama homma jos healthpoints ulko pinnassa on muuta design mitä on tuottu image png kuvana
    TÄMÄ MENEE TÄSSÄ JÄRJESTYKSESSÄ KUITENKIN:: Health Bar Canvas >> 
    */
    public Slider slider; //TÄMÄ ON UI >> HEALTHBAR CANVAS >> HEALTHBAR -> oikea valikkosta jokin komponentint slider

    public Gradient gradient; /*Tämä on sama kuin slider, mutta tässä määritellään esim. täys HP on vihreä, kesk: kel ja pian peli pelaaja kuolee: pun
    VALITSE MODE:STA Fixed, mitä tarkoittaa että missä suurin pirtein %% luvun mukaan muuttuu se väri esim. 29.3% muuttuu pun, 67.9% muuttuu keltainen ja jne.
    */

    //public Image fill; //TÄHÄN TULEE FILL

    //TÄMÄ ASETTUU SEN MAKSIMI HEALTH POINTS MÄÄRN MUKAAN ELI SCIRPTIN PlayerHealth.cs >> hitpoints
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;

        //fill.color = gradient.Evaluate(1f); //
    }

    public void SetHealth(float health)
    {
        slider.value = health;

        //fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
