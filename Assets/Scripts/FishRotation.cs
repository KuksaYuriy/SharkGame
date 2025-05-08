//using System.Numerics;
using UnityEngine;

public class FishRotation : MonoBehaviour
{
    public float rotateTime = 2;
    private float timer = 0;

    void Update()
    {
        timer -= Time.deltaTime;
        Vector3 look = transform.right;

        if (timer <= 0)
        {
            look = Random.insideUnitCircle;
            look.z = 0;
            transform.right = look;
            timer = rotateTime;
        }

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        if (renderer == null)
        {
            Debug.LogError("SpriteRenderer in FishRotation is missing");
        }
        float x = look.x;

        if (x > 0)
        {
            renderer.flipY = false;
        }

        else
        {
            renderer.flipY = true;
        }
    }
}
