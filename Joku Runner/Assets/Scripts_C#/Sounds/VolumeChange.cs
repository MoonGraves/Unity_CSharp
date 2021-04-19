using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    //TÄMÄ KUULUU UI >> MUSIC PANEL & BACKGROUND MUSIIKILLE & TÄMÄ ON BACKGROUND MUSIC ASIA, EI SAA SEKOA EFFECT MUSIIKKIN KANSSA
    //LISÄKSI VOI HALLITA MUSIIKKIN SLIDER VOLUMEN MÄÄRÄN, ELI ÄÄNI KOVEMALLE/PIENEMÄLLE & BUTTON SAMMUTTAA KAIKKI MUSIIKKIN & EFFECT ON/FF KAUTTA
    public Slider Volume;
    public AudioSource myMusic;

    //On-Off button
    private bool isMuted;

    // Start is called before the first frame update
    void Start()
    {
        //On-Off button
        isMuted = PlayerPrefs.GetInt("Muted") == 1;
        AudioListener.pause = isMuted;
    }

    //On-Off button
    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
    }

    //Asetttaa volume koon mukaan
    void Update()
    {
        //AudioSource.volume = musicVolume;
        myMusic.volume = Volume.value;
    }

}

