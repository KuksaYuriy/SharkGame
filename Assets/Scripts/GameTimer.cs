using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{
    public Text timerText;
    public float time; // in seconds
    void Start()
    {
        time = 60f;
    }
    
    void Update()
    {
        // Time -> MIN:SEC
        time -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(time % 60f);
        int minutes = Mathf.FloorToInt(time / 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // MM:SS
    }
}