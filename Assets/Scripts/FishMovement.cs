using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed = 50f;
    private float useSpeed = 50f;
    private Rigidbody2D body;
    public GameObject WaterSurface;
    public GameObject waterSplash;
    public bool inWater = true;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        WaterSurface = GameObject.Find("WaterSurface");
    }

    void Update()
    {
        Vector3 move = Vector3.right;
        move.Normalize();
        body.AddRelativeForce(move * useSpeed);

        if (transform.position.y < WaterSurface.transform.position.y)
        {
            useSpeed = speed;
            body.gravityScale = 0;
            body.drag = 1;
            inWater = true;
        }

        else
        {
            inWater = false;
            body.gravityScale = 1;
            body.drag = 0;
            useSpeed = 0;
        }
    }
}









//public float num1 = 29;
//public float num2 = 56;

//if (num1 > num2)
//{
//    Console.WriteLine("num1 > num2");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine("num1 < num2");
//}

//else if (num1 == num2)
//{
//    Console.WriteLine("num1 == num2");
//}

//else
//{
//    Console.WriteLine("Error!");
//}