using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour
{
    public float nextAttackTime = 0.7f;
    public float timerAttack = 0;
    public bool canAttack = true;
    public int damage = 1;
    public Slider enemyHpSlider;

    void Start()
    {
        enemyHpSlider.maxValue = 20;    
        enemyHpSlider.minValue = 0;
        enemyHpSlider.value = 20;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(canAttack + "can attack");
        if (collision.gameObject.CompareTag("Enemy") && Input.GetMouseButtonUp(0) && canAttack)
        {
            Attack(collision.gameObject);
            StartCoroutine(CooldownBetweenAttacks());
        }
    }

    void UpdateEnemyHpSlider(int enemyHP)
    {
        if (enemyHpSlider == null)
        {
            Debug.LogError("Missed EnemyHpSlider in AttackEnemy");
            return;
        }

        enemyHpSlider.value = enemyHP;
    }
    void Attack(GameObject enemy)
    {
        var enemyHP = enemy.GetComponent<EnemyHP>().enemyHP;

        if (enemyHP == null)
        {
            Debug.LogError($"Enemy {enemy.name} hasn't got component EnemyHP.");
            return;
        }
        enemyHP -= damage;

        enemy.GetComponent<EnemyHP>().enemyHP = enemyHP;
        UpdateEnemyHpSlider(enemyHP);
        if (enemyHP <= 0)
        {
            enemy.GetComponent<EnemyHP>().Die();
        }

        
        Debug.Log(enemyHP);
    }

    IEnumerator CooldownBetweenAttacks()
    {
        canAttack = false;
        yield return new WaitForSeconds(nextAttackTime);
        canAttack = true;
    }
}
