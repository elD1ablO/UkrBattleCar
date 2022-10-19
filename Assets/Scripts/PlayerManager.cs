using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    
    bool canJump;
    float jumpDelay = 3f;
    float jumpTimer = 3f;

    private void Update()
    {        
        jumpTimer -= Time.deltaTime;
        if (jumpTimer > 0) return;
        else canJump = true;

        if (Input.GetKeyDown(KeyCode.T) & canJump)
        {            
            ShakePlayer();
            canJump = false;
            jumpTimer = jumpDelay;           
        }
    }
    void ShakePlayer()
    {
        Rigidbody rb = playerPrefab.GetComponent<Rigidbody>();
        rb.AddForce(0, 6500, 7000, ForceMode.Impulse);
        rb.AddTorque(0, 0, 6000, ForceMode.Impulse);
    }
}
