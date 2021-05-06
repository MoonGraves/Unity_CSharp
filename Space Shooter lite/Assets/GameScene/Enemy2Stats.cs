using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Stats : MonoBehaviour
{
    [SerializeField] 
    GameObject bullet; //tähän tulee mikä prefabs bullet 

    [SerializeField] float fireRate;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1.25f; //laukauksen aika
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
