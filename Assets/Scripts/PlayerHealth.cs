using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event EventHandler OnDamageTaken;

    int playerHealth = 100;       

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        OnDamageTaken?.Invoke(this, EventArgs.Empty);

        if (playerHealth <= 0)
        {
            //Debug.Log("DEAD");            
            GameManager.instance.HandleDeath();
        }
    }

    public int GetPlayerHealth()
    {
        return playerHealth;
    }
    
}
