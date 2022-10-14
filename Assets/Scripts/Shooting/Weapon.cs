using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using System;

public class Weapon : MonoBehaviour

{ 
    
    [SerializeField] Transform shootingPoint;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 10f;

    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect;

    [SerializeField] Ammo ammoSlot;
    [SerializeField] AmmoType ammoType;

    //[SerializeField] InputAction fireAction;
    //[SerializeField] TextMeshProUGUI ammoText;

    //[SerializeField] AudioSource shootAudio;

    [SerializeField] float timeBetweenShots = 0.3f;
    bool canShoot = true;
    

    void Awake()
    {
        //fireAction.performed += ctx => StartCoroutine(Shoot());
    }

    void OnEnable()
    {
        canShoot = true;
       // fireAction.Enable();
    }

    void OnDisable()
    {
       // fireAction.Disable();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Shoot());
        }
        //DisplayAmmo();
    }

    /*private void DisplayAmmo()
    {
        int currentAmmo = ammoSlot.GetCurrentAmmo(ammoType);
        ammoText.text = currentAmmo.ToString();
    }*/

    IEnumerator Shoot()
    {        
        if(canShoot == true)
        {
            canShoot = false;
            if (ammoSlot.GetCurrentAmmo(ammoType) > 0)
            {
                //shootAudio.Play();
                PlayMuzzleFlash();
                ProcessRaycast();
                ammoSlot.ReduceCurrentAmmo(ammoType);
            }
            yield return new WaitForSeconds(timeBetweenShots);
            canShoot = true;
        }
        
    }
    void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootingPoint.transform.position, shootingPoint.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);            
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }        
    }

    void PlayMuzzleFlash()
    {
        //muzzleFlash.Play();
    }

    void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 1f);
    }

}
