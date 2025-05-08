using UnityEngine;

public class EnemyEatingFish : MonoBehaviour
{
    public float enemyAteFish = 0f;
    public GameObject enemyMouth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Fish"))
        {
            enemyAteFish += 1f;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.name.Contains("Shark"))
        {
            //PlayerHP playerHP = collision.gameObject.GetComponent<PlayerHP>;
            //playerHP.Damage(1);
        }
    }
}
