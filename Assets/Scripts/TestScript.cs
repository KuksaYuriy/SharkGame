using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string playerName = "Shark";
    public int playerHP = 20;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"{playerName} took {damage} damage. Now {playerName} has {playerHP} HP ");
    }
}