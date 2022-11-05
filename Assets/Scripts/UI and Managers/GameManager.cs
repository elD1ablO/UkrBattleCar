using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject gameOverCanvas;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        gameOverCanvas.gameObject.SetActive(false);
    }

    public void HandleDeath()
    {
        gameOverCanvas.gameObject.SetActive(true);
        Time.timeScale = 0f;        
    }
}
