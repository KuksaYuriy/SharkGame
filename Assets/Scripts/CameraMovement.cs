using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float cameraSpeed = 0.02f;
    
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, cameraSpeed);
    }
}