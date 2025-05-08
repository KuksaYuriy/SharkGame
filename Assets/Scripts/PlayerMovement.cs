using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    private float useSpeed = 50f;
    private Rigidbody2D body;
    public GameObject waterSurface;
    public GameObject waterSplash;
    public bool inWater = true;
    private Vector3 posBeforeCollisionBorder;
    public bool canMove = false;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        if (body == null)
        {
            Debug.LogError("No Rigidbody2D in PlayerMovement component attached");
        }
        // waterSurface = GameObject.Find("WaterSurface");
    }

    void Update()
    {
        //posBeforeCollisionBorder = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, vertical, 0);
        move.Normalize();

        if (canMove)
        {
            body.AddRelativeForce(move * useSpeed);
        }
        if (transform.position.y < waterSurface.transform.position.y)
        {
            body.gravityScale = 0;
            body.drag = 1;
            useSpeed = speed;

            if (!inWater)
            {
                Vector3 splashPosition = transform.position;
                splashPosition.y = waterSurface.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPosition, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }
            inWater = true;
        }

        else
        { 
            body.gravityScale = 1;
            body.drag = 0;
            useSpeed = 0;
            if (inWater)
            {
                Vector3 splashPosition = transform.position;
                splashPosition.y = waterSurface.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPosition, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }

            inWater = false;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            canMove = false;
        }

        else
        {
            canMove = true;
        }
    }
}