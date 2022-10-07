using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableObjectBehavior : MonoBehaviour
{
    BoxCollider boxCollider;
    MeshRenderer meshRenderer;
    void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
