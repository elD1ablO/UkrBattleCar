using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ShakePlayer();
        }
    }
    void ShakePlayer()
    {
        Rigidbody rb = playerPrefab.GetComponent<Rigidbody>();
        rb.AddForce(0, 6500, 7000, ForceMode.Impulse);
    }
}
