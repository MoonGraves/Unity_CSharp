using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //ENEMY asetettaan jokin target, etttä seuraa x henkilön perään
    // Start is called before the first frame update
    //[SerializeField] Transform target; //target jahtaa pelaajan
    [SerializeField] float chaseRange = 10f; //seuraa / jahtaa pelaajan  & että saapuu sen tietyn lähistöllä alkaa jahtaa
    [SerializeField] float turnSpeed = 5f; //kääntää katseen eli ENEMY katsoo pelajaan kohti
    Transform target;

    bool isProvoked = false;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity; //pituus target & että määrittyy x metri niin lopettaa jahtaamisen
    EnemyHealth health;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponent<EnemyHealth>();

        target = FindObjectOfType<PlayerHealth>().transform; //target jahtaa pelaajan
    }

    // Update is called once per frame
    void Update()
    {
        //JOS ENEMY KUOLEE tekee jotakin
        if (health.IsDead())
        {
            enabled = false;
            navMeshAgent.enabled = false;
        }

        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (isProvoked) 
        {
            EngageTarget();
        }

        //Jahtaamis homma etäisyys
        else if (distanceToTarget <= chaseRange) 
        {
            isProvoked = true; 
            //navMeshAgent.SetDestination(target.position);
        }
    }

    public void OnDamageTaken() //ENEMy havaitsee kun pelaajaa ampuu sitä kerran, niin tulee jahtaa pelajaan kimpuun
    {
        isProvoked = true;
    }

    private void EngageTarget()
    {   
        FaceTarget();
        //Jahtaa pelaajaan
        if (distanceToTarget >= navMeshAgent.stoppingDistance) 
        {
            ChaseTarget(); //methodi löytyy alhaalta
        }

        //Hyökkää pelaajaan
        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget(); //methodi löytyy alhaalta
        }

    }

    //Jahtaamis ja isketty methodi
    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move"); //animator mitä enemy tekeekäään
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attack", true); //iskee jotakin esim. käsi tai muu vastaava
        Debug.Log(name + "has seeked and is destroying " + target.name);
    }

    //ENEMY KÄÄNTÄÄ KATSEEN
    private void FaceTarget()
    {
        Vector3 direction = ( target.position - transform.position ).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z ));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
        // transform.rotation = where the target is & certain speed
    }

    ////////////////
    //ENEMY jahtamis range eli millä etäisyydellä hän jahtaa sen ympärillä n. 10f
    void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange );
    }
}
