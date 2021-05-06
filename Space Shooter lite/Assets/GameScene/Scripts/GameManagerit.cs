using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerit : MonoBehaviour
{
    public GameObject playerButton;
    public GameObject menuButton;
    public GameObject playerShip;

    public GameObject enemySpawner;

    public GameObject GameOverGO; 

    public GameObject scoreUITextGO;

    public GameObject BeginPanel;


    // Start is called before the first frame update

    public enum GameManagerState
    {
        Opening,
        GamePlay,
        GameOver
    }

    GameManagerState GMState;
    void Start()
    {
        GMState = GameManagerState.Opening;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to update the game mangaer site
    void UpdateGameManagerState()
    {
        switch(GMState)
        {
            case GameManagerState.Opening:
                //hide game over

                GameOverGO.SetActive(false);

                playerButton.SetActive(true);

                menuButton.SetActive(true);

                BeginPanel.SetActive(true);

                break;

            case GameManagerState.GamePlay:
                playerButton.SetActive(false);

                menuButton.SetActive(false);

                BeginPanel.SetActive(false);

                //reset the score
                scoreUITextGO.GetComponent<GameScore>().Score = 0;
                
                playerShip.GetComponent<PlayerControl>().Init();

                //start enemy spawner
                enemySpawner.GetComponent<EnemySpawner>().ScheduleENemySpawner();

                break;
            case GameManagerState.GameOver:
                //stop enemy spawner, dipslay game over 
                enemySpawner.GetComponent<EnemySpawner>().UnscheduleEnemySpawner();

                Invoke("ChangeToOpeningState", 5f); //PLay button toistaa uudestaan, että voi pelata uudestaan

                GameOverGO.SetActive(true);

                break;
        }
    }

    public void SetGameManagerState(GameManagerState state)
    {
        GMState = state;
        UpdateGameManagerState ();
    }

    //Game button function
    public void StartGamePlay()
    {
        GMState = GameManagerState.GamePlay;
        UpdateGameManagerState();
    }

    //funtio change game manager state opening state
    public void ChangeToOpeningState()
    {
        SetGameManagerState(GameManagerState.Opening);
    }
}
