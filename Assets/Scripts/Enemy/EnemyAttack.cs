using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    
    PlayerHealth target;
    [SerializeField] int damage = 5;
    //[SerializeField] AudioSource attackSound;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        //attackSound = GetComponent<AudioSource>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
        //target.GetComponent<DisplayDamage>().ShowDamageCanvas();
        //attackSound.Play();
    }
    
}
