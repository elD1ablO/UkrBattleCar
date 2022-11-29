using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    [Tooltip("Increase this if you want car to make more damage on collision with enemy")]
    [SerializeField] float damageDependingOnVelocityMultiplier = 0.3f;

    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") 
        {            
            EnemyHealth target = collision.gameObject.GetComponent<EnemyHealth>();            
            target.TakeDamage(collideDamage());
        }
    }

    void OnCollisionStay(Collision collision)
    {        
        if (collision.gameObject.tag == "Enemy")
        {           
            EnemyHealth target = collision.gameObject.GetComponent<EnemyHealth>();
            target.TakeDamage(collideDamage() * 0.01f);
            
        }
    }

    float collideDamage()
    {
        float amount;
        amount = (Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z)) * damageDependingOnVelocityMultiplier;
        Debug.Log(amount);
        return amount;
    }

}
