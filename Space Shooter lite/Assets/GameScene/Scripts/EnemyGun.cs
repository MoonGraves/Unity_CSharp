using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBulletGO; //tähän tulee se enemy bullet kuva

    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //fire an enemy bullet after 1 seconds
        Invoke("FireEnemyBullet", 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    
    void FireEnemyBullet()
    {
        GameObject playerShip = GameObject.Find("PlayerGO");

        if(playerShip != null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGO);

            //set the bullet's initial position
            bullet.transform.position = transform.position;

            Vector2 direction = playerShip.transform.position - bullet.transform.position;

            bullet.GetComponent<EnemyBullet>().SetDirection(direction);
        }
    }
    
}
