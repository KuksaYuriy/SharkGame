using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    { 
        Vector3 mouse = Input.mousePosition;
        Vector3 player = transform.position;
        Vector3 mouseInUnity = Camera.main.ScreenToWorldPoint(mouse);
        Vector3 look = mouseInUnity - player;

        look.z = 0;
        transform.right = look;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

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
