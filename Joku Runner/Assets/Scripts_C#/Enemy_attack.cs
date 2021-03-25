using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_attack : MonoBehaviour
{
    //Enemy attack

    PlayerHealth target;
    [SerializeField] float damage = 40f;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDamageTaken() //ENEMy havaitsee kun pelaajaa ampuu sitä kerran, niin tulee jahtaa pelajaan kimpuun
    {
        Debug.Log(name + "I know player hit me");
    }

    public void AttackHitEvent()
    {
        if ( target == null ) return;
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
        //Debug.Log("Bang bang");
    }

}
