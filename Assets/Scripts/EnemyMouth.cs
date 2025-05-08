using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMouth : MonoBehaviour
{
   void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHP playerHP = other.gameObject.GetComponent<PlayerHP>();
            playerHP.Damage(1);
        }
    }
}
