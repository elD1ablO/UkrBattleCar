using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] GameObject inGameCanvas;
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        gameOverCanvas.gameObject.SetActive(false);
        inGameCanvas.gameObject.SetActive(true);
    }

    public void HandleDeath()
    {
        gameOverCanvas.gameObject.SetActive(true);
        inGameCanvas.gameObject.SetActive(false);

        Time.timeScale = 0f;        
    }
}
