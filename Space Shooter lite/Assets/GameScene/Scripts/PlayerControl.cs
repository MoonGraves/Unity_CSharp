using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerControl : MonoBehaviour
{
    //SPACE SHOOTER PELAAJA CONTROLLIT
    //nuoli näppäimet & AWSD

    public GameObject GameManagerGO;

    public GameObject PlayerBulletGo;
    public GameObject BulletPos1;
    public GameObject BulletPos2;

    public AudioSource shootSound; //player shooting sound by keyboard space

    public GameObject ExplosionGO; //playership explosion animation
    public float speed; //pelaajan liikkuvuuden nopeus

    //ui text
    public TextMeshProUGUI LivesUIText;

    const int MaxLives = 3; //live määrä
    int lives;

    public void Init()
    {
        lives = MaxLives;

        LivesUIText.text = lives.ToString();

        //reset player positions on center of the screen
        transform.position = new Vector2 (0,0);

        //game object active
        gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //aseen laukkaus homma
        if(Input.GetKeyDown("space"))
        {
            //play sounds
            shootSound.Play();

            GameObject bullets01 = (GameObject) Instantiate (PlayerBulletGo);
            bullets01.transform.position = BulletPos1.transform.position;

            GameObject bullets02 = (GameObject)Instantiate (PlayerBulletGo);
            bullets02.transform.position = BulletPos2.transform.position;
        }

        //liikkuvuus horizonti ja vertical
        float x = Input.GetAxisRaw("Horizontal"); //value be -1 or 0 or 1, to left or right
        float y = Input.GetAxisRaw("Vertical"); //value be -1 or 0 or 1, to down or forward

        //base input direction vector
        Vector2 direction = new Vector2 (x, y).normalized;

        //funktio computes and sets player's positions
        Move(direction);
    }

    void Move(Vector2 direction)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0,0 ));
        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1,1 ));

        max.x = max.x - 0.225f;
        min.x = min.x + 0.225f;

        max.y = max.y - 0.285f;
        min.y = min.y + 0.285f;

        Vector2 pos = transform.position;

        pos += direction * speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if((col.tag == "EnemyShipTag") || (col.tag == "EnemyBulletTag"))
        {
            PlayerExplosion();

            lives--; //lives vähenee kokoajan
            LivesUIText.text = lives.ToString();

            if(lives == 0)
            {
                //Destroy(gameObject);
                GameManagerGO.GetComponent<GameManagerit>().SetGameManagerState(GameManagerit.GameManagerState.GameOver);
                gameObject.SetActive(false);
            }
        }    
    }

    //instantiate the an explosion
    void PlayerExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

        explosion.transform.position = transform.position;
    }
}
