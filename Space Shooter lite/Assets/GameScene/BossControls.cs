using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControls : MonoBehaviour
{
    //Boss liikkuvuus vasemmasta oikealle
    //public float min = 2f;
    //public float max = 3f;

    GameObject scoreUITextGO; //reference to text ui game object
    public GameObject ExplosionGO; //enemy explosion animation

    public float movementSpeed = 0.04f;
 
    private Rigidbody rb;
    private Vector3 endPosition = new Vector3(0, 3, 0);

    public static float healthAmount;

    // Start is called before the first frame update
    void Start()
    {

        //min = transform.position.x;
        //max = transform.position.x+3;
        rb = GetComponent<Rigidbody>();

        healthAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
        /*if(transform.position != endPosition) {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
        }*/

        if(healthAmount <= 0)
            Destroy(gameObject);
    }

    //Boss dead
    void OnTriggerEnter2D(Collider2D col) 
    {
        if((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            PlayEnemyExplosion();

            //add xy points to the scores;
            scoreUITextGO.GetComponent<GameScore>().Score += 500;

            healthAmount -= 0.1f;

            Destroy(gameObject);
        }
    }

    void PlayEnemyExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

        explosion.transform.position = transform.position;
    }

}
