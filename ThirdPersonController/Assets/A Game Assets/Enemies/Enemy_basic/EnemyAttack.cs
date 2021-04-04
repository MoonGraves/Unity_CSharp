using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Enemy attack
    
    //ASETA JOS ENSIMMÄISEN ENEMY HYÖKKÄÄ PELAAJAAN, ASETA NOI Animator.cs sieltä >> Appply Root Motion päälle, & Update Mode (Animate Phyics)
    //TÄÄ TARKOITTAA, ETTÄ TEKEE SAMAN ANIMATION TAI TEMPUN , ETTÄ HYÖKKÄÄ PELAAJAN KIMPPUUN JA JNE

    PlayerHealth target;
    [SerializeField] float damage = 20f;

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
