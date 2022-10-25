using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hp = 100f;
    [SerializeField] GameObject deathParticles;

    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }
 
    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");

        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        if (isDead) return;
        isDead = true;
        Destroy(gameObject);        
        //GetComponent<Animator>().SetTrigger("die");
    }
}
