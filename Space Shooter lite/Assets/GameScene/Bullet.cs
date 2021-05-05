using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 3f;

    Rigidbody2D rigidb;

    PlayerControl playerTarget;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
        playerTarget = GameObject.FindObjectOfType<PlayerControl>();
        moveDirection = (playerTarget.transform.position - transform.position).normalized * moveSpeed;
        rigidb.velocity = new Vector2 (moveDirection.x , moveDirection.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name.Equals("PlayerGO"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
