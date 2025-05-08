using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public float rotateTime = 2f;
    public float timer = 0f;
    public EnemyEyes enemyEyes;

    void Start()
    {
        enemyEyes = GetComponentInChildren<EnemyEyes>();
    }

    void Update()
    {
        Vector3 look = transform.right;
        if (enemyEyes.target == null)
        {
            timer += Time.deltaTime;

            if (timer >= rotateTime)
            {
                look = Random.insideUnitCircle;
                transform.right = look;
                timer = 0f;
            }
        }

        else
        {
            Vector3 targetPos = enemyEyes.target.transform.position;
            look = targetPos - transform.position;
            transform.right = look;
        }

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        if (renderer == null)
        {
            Debug.LogError("SpriteRenderer in EnemyRotation is missing");
        }
        if (look.x > 0)
        {
            renderer.flipY = false;
        }
        
        else
        {
            renderer.flipY = true;
        }
    }
}