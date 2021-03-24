using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //ONLY FOR WEAPONS CAN SHOOT & vain se yks rynkky

    [SerializeField] Camera FPCamera; //tähän tulee (MainCamera)
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f; //30 damagee aseesta

    [SerializeField] ParticleSystem muzzleFlash; //ase laukaus piippun pää bang bang & vähä kuin flash (Muzzle Flash)

    [SerializeField] GameObject hitEffect; //jokin object saa osumman & effecti näkyvät & (Hit Effect )


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        PlayMuzzleFlash();
        ProcessRaycast();
    }

    private void PlayMuzzleFlash() //Laukausen aseen piipun pään effecti
    {
        muzzleFlash.Play();
    }
    
    //Laukkaus methodi, että fps niin kuin ampuu kameran siitä suunnasta miten me oikein halutaan
    private void ProcessRaycast()
    {
        RaycastHit hit;
        if ( Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range)) 
        {
            Debug.Log("I hit this thing " + hit.transform.name); //osuu vaikka mitäkin esim. talo, monsteri, pilari ja jne

            CreateHitImpact(hit);

            //TODO: some hit effect for visual player & lukaisee EnemyHealth tiedoston - kantsii olla tarkanna nimeämisen toisen tiedoston lukemista
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();

            if(target == null) return;
            //enemy_health decreases the enemy's health
            target.TakeDamage(damage);
        }

        else 
        {
            return;
        } 
    }

    private void CreateHitImpact(RaycastHit hit) 
    {
       GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
       Destroy(impact, .1f); //yksi sekuntti
    }
}
