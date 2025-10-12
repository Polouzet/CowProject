using UnityEngine;

public class S_Mouvement : MonoBehaviour
{
    float speed;
    public float baseSpeed;
    Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = baseSpeed;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


        rb.linearVelocity = new Vector2(horizontal * speed, vertical * speed);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 2f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = baseSpeed;
        }
    }
}
