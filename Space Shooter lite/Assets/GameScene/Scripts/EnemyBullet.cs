using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 direktion; //direkti of the bullet

    bool isReady; //known when the bullet direction is set


    // Start is called before the first frame update
    void Awake()
    {
        speed = 0f;
        isReady = false;
    }

    void Start()
    {

    }

    //set bullet's direction
    public void SetDirection(Vector2 direction)
    {
        direktion = direction.normalized;
        
        isReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isReady)
        {
            Vector2 position = transform.position;

            position += direktion * speed * Time.deltaTime;

            transform.position = position;

            //if the bullet goes outside the screen

            Vector2 min = Camera.main.ViewportToWorldPoint ( new Vector2 (0,0));

            Vector2 max = Camera.main.ViewportToWorldPoint ( new Vector2 (1,1));

            //if the bullet goes outside the screen, then destroy it
            if((transform.position.x < min.x) || (transform.position.x > max.x) ||
               (transform.position.y < min.y) || (transform.position.y > max.y))
            {
                Destroy(gameObject);
            }
        }
    }

}
