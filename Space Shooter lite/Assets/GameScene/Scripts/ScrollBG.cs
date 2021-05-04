using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    //Background scroll
    public float scrollSpeed = 5f;
    private Vector3 StartPosition;


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
        
        if(transform.position.y < -20.29f)
        {
            transform.position = StartPosition;
        }
    }
}
