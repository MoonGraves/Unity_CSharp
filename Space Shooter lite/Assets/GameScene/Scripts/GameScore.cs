using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreTextUI;

    int score;

    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            this.score = value;
            UpdateScoreTextUI();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //get text ui component of this gameobject
        scoreTextUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void UpdateScoreTextUI()
    {
        string scoreStr = string.Format ("{0:00000}", score);
        scoreTextUI.text = scoreStr;
    }
}
