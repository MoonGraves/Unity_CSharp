using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyControl : MonoBehaviour
{
    //tää kuulluu enemy:lle
    // Start is called before the first frame update

    GameObject scoreUITextGO; //reference to text ui game object

    public GameObject ExplosionGO; //enemy explosion animation

    public GameObject EnemyBulletGO; //tähän tulee se enemy bullet kuva
    
    float speed; 

    void Start()
    {
        speed = 4f;

        //get scores
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");
    }

    // Update is called once per frame
    void Update()
    {
        //enemmy current position
        Vector2 position = transform.position; 

        position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2 (0,0));

        if(transform.position.y < min.y)
        {
            Destroy(gameObject);
        } //kun enemy lentää sinne alas niin se tuhoutuu itseksen

    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            PlayEnemyExplosion();

            //add xy points to the scores;
            scoreUITextGO.GetComponent<GameScore>().Score += 50;

            Destroy(gameObject);
        }
    }

    void PlayEnemyExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

        explosion.transform.position = transform.position;
    }
}
