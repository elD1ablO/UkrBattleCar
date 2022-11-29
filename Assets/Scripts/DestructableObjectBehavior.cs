using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestructableObjectBehavior : MonoBehaviour
{
    [SerializeField] float timeBeforeDestruction = 5f;
    [SerializeField] GameObject destroyParticles;
        
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (destroyParticles != null)
            {
                GameObject particles = Instantiate(destroyParticles, transform.position, Quaternion.identity);
                particles.transform.parent = null;
            }

            Destroy(gameObject, timeBeforeDestruction);
        }
        
    }
}
