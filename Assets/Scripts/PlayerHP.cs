using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerHP : MonoBehaviour
{
    public int playerHP = 20;
    public Text playerHPText;
    public Image panel;
    public float animSpeed = 2f;
    float effectAlpha = 0;

    void Start()
    {
        playerHPText.text = Convert.ToString(playerHP) + "HP";
    }

    void Update()
    {
        PanelEdit();
    }

    public void Damage(int damage)
    {
        playerHP -= damage;
        playerHPText.text = Convert.ToString(playerHP) + "HP";
        if (playerHP <= 0) 
        {
            playerHP = 0;
        }

        if (playerHP == 0) 
        { 
            Scene current = SceneManager.GetActiveScene();
            SceneManager.LoadScene(current.name);
        }
        StartCoroutine(DamageEffect());      
    }
    IEnumerator DamageEffect()
    {
        effectAlpha = 1;
        yield return new WaitForSeconds(0.5f);
        effectAlpha = 0;
    }

    void PanelEdit()
    {
        float realAlpha = panel.color.a;
        Color color = panel.color;
        float alpha2 = Mathf.Lerp(realAlpha, effectAlpha, Time.deltaTime * animSpeed);
        color.a = alpha2;
        panel.color = color;
    }
}
