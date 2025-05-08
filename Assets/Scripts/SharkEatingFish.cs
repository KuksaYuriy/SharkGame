using System;
using UnityEngine;
using UnityEngine.UI;

public class SharkEatingFish : MonoBehaviour
{
    public GameObject sharkMouth;
    public float sharkAteFish = 0f;
    public Text ateFishText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Fish"))
        {
            sharkAteFish += 1f;
            Destroy(collision.gameObject);
            ateFishText.text = Convert.ToString(sharkAteFish) + " Eaten Fish";
        }
    }
}
