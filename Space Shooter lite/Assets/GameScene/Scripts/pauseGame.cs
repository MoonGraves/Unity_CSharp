using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    //TÄMÄ KONTROLLOI, ETTÄ SAA PAUSE SYSTEEMIN GUIDE ASIAT ELI BUTTON JA YMS PANEL, MITÄ JOKAISELLA ON
    //ESIM. 1-BUTTON AVAA MITÄ KAIKKEA KONTROLLIA TÄS ON, 3-BUTTON AVAA INVENTORY JA JNE

    [SerializeField] private GameObject pauseMenuUI;

    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //esc
        if (Input.GetKeyDown(KeyCode.P))
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
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenuUI.SetActive(false);
    }
    
}
