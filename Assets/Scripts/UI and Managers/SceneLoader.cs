using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneLoader : MonoBehaviour
{
    public void Reload()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(2);        
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif        
    }
}
