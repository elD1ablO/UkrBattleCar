using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{
    
    [SerializeField] Image fillingBar;

    float startDelay = 3;

    int sceneID = 1;

    void Start()
    {
        StartCoroutine(LoadSceneAsync(sceneID));
    }
    IEnumerator LoadSceneAsync(int sceneID)
    {         

        for (int i = 0; i < startDelay + 1; i++)
        {
            fillingBar.fillAmount = i * 0.3f;

            yield return new WaitForSeconds(1f);
        }
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
    }

}
