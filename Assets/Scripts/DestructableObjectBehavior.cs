using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestructableObjectBehavior : MonoBehaviour
{
    [SerializeField] float timeBeforeDestruction = 5f;
    BoxCollider boxCollider;
    MeshRenderer meshRenderer;
    void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Destroy(gameObject, timeBeforeDestruction);
        }
        
    }
}
