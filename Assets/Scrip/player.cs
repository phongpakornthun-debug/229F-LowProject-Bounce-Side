using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // เช็คว่าติดพื้นอยู่ไหม
        if (Physics.Raycast(transform.position, Vector3.down, 1.1f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        // กระโดด
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            float mass = rb.mass;
            float acceleration = jumpForce;

            float force = mass * acceleration;

            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // A, D

        Vector3 move = new Vector3(moveX, 0, 0); // ขยับแค่แกน X

        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);

        if (moveX > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0); // หันขวา
        }
        else if (moveX < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0); // หันซ้าย
        }
    }
   
}
