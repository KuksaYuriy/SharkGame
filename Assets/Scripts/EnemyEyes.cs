using UnityEngine;

public class EnemyEyes : MonoBehaviour
{
    public GameObject target = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name.Contains("Shark"))
        {
            target = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Shark"))
        {
            target = null;
        }
    }
}
