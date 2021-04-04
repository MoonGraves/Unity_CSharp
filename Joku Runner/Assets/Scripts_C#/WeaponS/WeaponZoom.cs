using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    //WEAPON ZOOM & ASEEN ZOOMAUS & FOV (Field Of View) & tää liittyy (MainCamera), 
    //eli fps tai muu tarkkuus & oletus n. 60 ja zoom 20-25

    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController; //using UnityStandardAssets.Characters.FirstPerson; & drag tähän Player

    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    //Antaa käyttäjään painaa pohjaa oikea hiiren näppäimmen pitempää ja laukausee luotit
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;

    bool zoomedInToggle = false;

    private void OnDisable() 
    {
        ZoomOut();
    }
    //Kuin snipperi hiiren oikea näppäin zoom sen tarkkuuden
    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();

            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }


}
