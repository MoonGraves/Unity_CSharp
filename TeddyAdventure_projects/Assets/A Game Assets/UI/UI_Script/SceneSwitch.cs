using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//public class SceneSwitch : MonoBehaviour
//{
    //SCENE VAIHTO ESIM. PELAAJA HYPPÄISI TOISEEN RUUTUUN TAI MENEE OVESTA LÄVITSE, JONKA JÄLKEEN SE ON TOINEN MAAILMA TAI KUIN LÄHTEE ULOS
    /*SEN VÄLISSSÄ EI OLE MITÄÄN, ETTÄ LOADING TAI VASTAAVAA

    Tässä tulee olemaan järjestys luku, että mikä scene on A->B-> ja jne~~ 
    toki jos pelaaja (kuolee) leikkisti & tippuu jostai "plane" alueesta, nin hän voi palata pelin alkuunkin esim.

    Kuinka määrität scene järjestyksen? AVAA File >> Build Setttings & 
    Sieltä voit raaha itse mikä scene tulee ensimmäisenä, muista nämä kulkeutuvat [ARRAY] JÄRJESTYKSESSÄ ELI 0 1 2 3 JA JNE
    ESIM. MAINMENU ON 0, KUN PELAAJA KLIKKAA (PLAY) NIIN AVATUU PELI MAAILMA & JOS PELAAJA LÖYTÄÄ SALAISEN OVEN / REITIN, JOSTA HÄN PÄÄSEE JOHONKIN AUTOMAAAHAN ESIM.
    AUTOMAAN SCENESSÄ TULEE OLEMAAN SAMA KUIN PELI MAAILAM ASETUKSET & SEKÄ XYZ AKSELI MISSÄ PELAAJAN SIJAINTI SIJAITSEE
    */
//    void OnTriggerEnter(Collider other) 
//    {
//        SceneManager.LoadScene(1);
//    }
//}
