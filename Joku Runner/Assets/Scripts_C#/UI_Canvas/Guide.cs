using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Guide : MonoBehaviour
{
    //avaa guide nappin & ja muu button nappit & GUIDE BUTTON NAPPI EI TOIMI TÄSSÄ
    //avaa Button sieltä --> button scrolla als kuin on click(), rahaa canvas/button tämä osuus siihen , ja funktio guide --> open panel()
    //scriptin sisään raahaat panel & 
    public GameObject Panel;
    [SerializeField] private GameObject pauseMenuUI;

    private bool GuideEnabled;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            Debug.Log("Avasit Guide / Pause the Game");
            Update();
        }       
    }

    public void Start() 
    {
        
    }

    public void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GuideEnabled = !GuideEnabled;
        }

        if(GuideEnabled)
        {
            Panel.SetActive(true);
            PauseGame();
        }
        
        else
        {
            Panel.SetActive(false);
            ResumeGame();
        }

    }
    
    public void PauseGame ()
    {
        Time.timeScale = 0f;
        Debug.Log("Pause the Game");
        pauseMenuUI.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        Debug.Log("Resume the Game");
    }

    //ONLY BUTTON *CLICK* JUMP TO ANOTHER SCENE
    public void btn_ToScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
        Debug.Log("PLAYER QUIT THE APPLICATION");
    }
}
