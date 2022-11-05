using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hp = 100f;
    [SerializeField] ParticleSystem deathParticles;

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

        ParticleSystem blood = Instantiate(deathParticles,transform.position, Quaternion.identity);
        blood.transform.parent = null;
        blood.Play();

        Destroy(gameObject);
        //GetComponent<Animator>().SetTrigger("die");
    }

}
