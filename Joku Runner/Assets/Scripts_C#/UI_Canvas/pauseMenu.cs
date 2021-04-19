using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    //TÄMÄ KONTROLLOI, ETTÄ SAA PAUSE SYSTEEMIN GUIDE ASIAT ELI BUTTON JA YMS PANEL, MITÄ JOKAISELLA ON
    //ESIM. 1-BUTTON AVAA MITÄ KAIKKEA KONTROLLIA TÄS ON, 3-BUTTON AVAA INVENTORY JA JNE
    [SerializeField] private GameObject pauseMenuUI;

    private bool isPaused;

    //ESC button
    void Update() 
    {
        //esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if(isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }
    
    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}
