using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP = 20;
    public GameObject target;
        
    [SerializeField] public void Die()
    {
        if (transform.gameObject == null)
        {
            Debug.LogError("transform.gameObject in EnemyHP is missing");
            return;
        }
        Destroy(target.transform.gameObject);
        Debug.Log("Enemy Died");

        SceneManager.LoadScene(3);
    }
}