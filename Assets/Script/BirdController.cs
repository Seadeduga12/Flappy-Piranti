using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Uji menggunakan keyboard dulu
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}
