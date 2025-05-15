using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMouth : MonoBehaviour
{
    public float cooldownBetweenAttack = 1.5f;
    public bool canAttack = true;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && canAttack)
        {
            PlayerHP playerHP = other.gameObject.GetComponent<PlayerHP>();
            playerHP.Damage(1);
            StartCoroutine(CooldownBetweenAttack());
        }
    }

    IEnumerator CooldownBetweenAttack()
    {
        canAttack = false;
        yield return new WaitForSeconds(cooldownBetweenAttack);
        canAttack = true;
    }
}
