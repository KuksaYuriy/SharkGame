using System;
using UnityEngine;
using UnityEngine.UI;

public class SharkTakingCoin : MonoBehaviour
{
    public int score = 0;
    public GameObject coin;
    public Collision2D collision;
    public Text coinText;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Coin"))
        {
            score += 1;
            Destroy(collision.gameObject);
            coinText.text = Convert.ToString(score) + " Coins";
        }
    }
}
