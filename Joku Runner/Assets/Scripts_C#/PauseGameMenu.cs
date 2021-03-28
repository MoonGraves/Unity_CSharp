using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameMenu : MonoBehaviour
{
    //PAUSE THE GAME MENU SCRIPT

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    /*
    
    */
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //(KeyCode.Escape) << ESC
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }    
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = false;
    }

}
