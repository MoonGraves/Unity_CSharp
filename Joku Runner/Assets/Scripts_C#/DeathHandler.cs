using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas; // Tähän tulee kokonainen (Game over Canvas)

    //START THE GAME
    private void Start() 
    {   
        gameOverCanvas.enabled = false; //Kun käynnistät pelin noi pari button lähtevät pois
    }

    //KUN PELAAJA KUOLEE / HÄVIÄÄ tekee osuman pelaajaan
    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
