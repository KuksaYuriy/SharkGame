using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSliderScript : MonoBehaviour
{
    public Slider loadingSlider;
    private void Start()
    {
        StartCoroutine(LoadingScene());
    }
    
    IEnumerator LoadingScene()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync("Game");
        loadAsync.allowSceneActivation = false;

        while (!loadAsync.isDone)
        {
            float progress = loadAsync.progress;
            loadingSlider.value = progress;
            
            if (progress >= 0.9f)
            {
                loadAsync.allowSceneActivation = true;
            }
            
            yield return new WaitForSeconds(1);
        }
    }
}