using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FrontDamage : MonoBehaviour
{
    Rigidbody rb;
    private void OnCollisionStay(Collision collision)
    {        
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(10);
        }        
    }
}
