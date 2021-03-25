using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // GAMEOVER CANVAS & UI >> GAME OVER CANVAS
    /*NAPPI- Play again & Siirrä tämä >> (PLAY AGAIN BUTTON) >> Scrolla alas (BUTTON) >> On click () mitä aluksi lukee (List is Empty)
    klikkaa sieltä oikea ala kulmasta pikku + , ja raahaa tämä scriptti siihen missä lukee (None Object) & kuin lukaisee tämän file.cs
     missä lukee, tyhjä funktio sieltä valitset >> Scene Loader >> Reload Game() & minkä jälkeen ponnahtaa SceneLoader.ReloadGame
    
    Sama homma QUIT game button menee kuin toi ensimmäinen , paitsi tyhjä funktiossa sieltä valitset >> Scene Loader >> Quit Game()
    */
    public void ReloadGame()
    {
        SceneManager.LoadScene(0); //Reload the game , asettaa pelajan samaan alku lähtö pisteeseen 
        //& käynnistetään pelin pelaaminen uuestaan
        Time.timeScale = 1;

    }

    //QUIT THE GAME
    public void QuitGame()
    {
        Application.Quit();
    }
}
