using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class Weapon : MonoBehaviour
{
    //ONLY FOR WEAPONS CAN SHOOT & vain se yks rynkky

    [SerializeField] Camera FPCamera; //tähän tulee (MainCamera)
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f; //30 damagee aseesta

    [SerializeField] ParticleSystem muzzleFlash; //ase laukaus piippun pää bang bang & vähä kuin flash (Muzzle Flash)

    [SerializeField] GameObject hitEffect; //jokin object saa osumman & effecti näkyvät & (Hit Effect )
    [SerializeField] Ammo ammoSlot; //lukaisee ammo class scriptin
    [SerializeField] AmmoType ammoType; //ase oma tyyppi eli pistooli, shotgun ja jne & itse voi määrittää sen luokituksen Ammo.cs shell, rocket ja jne ja paljon ammo määrä on

    [SerializeField] float timeBetweenShots = 0.5f; //ajan laukaus, että monta sekunttia per käyttäjä saisi laukauksen & vaikka kuinka usein klikkailee sen alle 0.5s

    [SerializeField] TextMeshProUGUI ammoText; //pelajaa näkee paljon pannosta on käytettävissä

    bool canShoot = true;

    private void onEnablde()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAmmo();
        if (Input.GetMouseButtonDown(0) && canShoot == true ) 
        {
           StartCoroutine(Shoot());
        }
    }

    //Tulostetaan paljon ammoa käyttäjällä on aktivoituneena
    private void DisplayAmmo ()
    {
        int currentAmmo = ammoSlot.GetCurrentAmmo(ammoType);
        ammoText.text = currentAmmo.ToString();
    }

    IEnumerator Shoot()
    {
        canShoot = false;

        //KUNNES AMMO LOPPUU EI ENÄÄ TOISTA SITÄ EFFECT JA MUU PANNOSTA
        if(ammoSlot.GetCurrentAmmo(ammoType) > 0 )
        {
            PlayMuzzleFlash();
            ProcessRaycast();
            ammoSlot.ReduceCurrentAmmo(ammoType);
        }

        yield return new WaitForSeconds(timeBetweenShots);
        canShoot = true;
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
