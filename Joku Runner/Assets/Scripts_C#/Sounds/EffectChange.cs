using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectChange : MonoBehaviour
{
    //TÄMÄ KUULUU UI >> MUSIC PANEL & EFFECT MUSIIKILLE & TÄMÄ ON BACKGROUND EFFECTT ASIA, EI SAA SEKOA EFFECT MUSIIKKIN KANSSA
    //LISÄKSI VOI HALLITA MUSIIKKIN SLIDER VOLUMEN MÄÄRÄN, ELI ÄÄNI KOVEMALLE/PIENEMÄLLE & BUTTON SAMMUTTAA KAIKKI MUSIIKKIN & EFFECT ON/FF KAUTTA
    public Slider effectVolum;
    public AudioSource myEffectMus;

    //On-Off button
    private bool isEffectMuted;

    // Start is called before the first frame update
    void Start()
    {
        //On-Off button
        isEffectMuted = PlayerPrefs.GetInt("Effect Muted") == 1;
        AudioListener.pause = isEffectMuted;
    }

    //On-Off button
    public void MutePressed()
    {
        isEffectMuted = !isEffectMuted;
        AudioListener.pause = isEffectMuted;
        PlayerPrefs.SetInt("Effect Muted", isEffectMuted ? 1 : 0);
    }

    //Asetttaa volume koon mukaan
    void Update()
    {
        //AudioSource.volume = musicVolume;
        myEffectMus.volume = effectVolum.value;
    }

}

