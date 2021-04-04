using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float CameraMoveSpeed = 120.0f; //kameran liikkuvuus nopeus
    public GameObject CameraFollowObj;

    Vector3 FollowPOS;
    public float clampAngle = 60.0f;
    public float inputSensitivity = 150.0f;

    public GameObject CameraObjs;
    public GameObject PlayerObj;

    //Jokin etäisyys kamerasta pelajaan
    public float camDistanceXToPlayer;
    public float camDistanceYToPlayer;

    //Hiiren klikkaus ja määritys kameran kanssa
    public float mouseX;
    public float mouseY;

    public float finalInputX;
    public float finalInputZ;

    public float smoothX;
    public float smoothY;

    //rotaatio x ja y
    private float rotY = 0.0f;
    private float rotX = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
