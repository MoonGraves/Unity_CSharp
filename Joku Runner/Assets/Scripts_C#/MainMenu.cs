using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //MAINMENU & OPTION MENU
    /*ASETA SCENE JÄRJESTYS, KOSKA TÄMÄ ON TÄRKEÄ, ETTÄ MAINMENU ON ENSIMMÄISESSÄ RUUDUSSA, JONKA JÄLKEEN PÄÄSEE PELAA & TOIMINTAAN
    
    FILE >> BUILD SETTINGS >> sieltä asetat mikä scene tulee ensimmäisenä, 
    tässä on määritetty että MENU on ensimmäisenä (MainMenu) ja jonka jälkeen tulee SANDBOX (GAME)
    */

    public void PlayGame()
    {
        //Käynnistää pelin
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    //PELAAJA POISTUU PELISTÄ
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player Quit");
    }
    
}
