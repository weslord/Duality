using UnityEngine;

public class OtherController : MonoBehaviour
{
    public float moveSpeed = 75f;

    public Vector2 incomingVelocity = new Vector2(0, 0);

    void FixedUpdate() {
        // float dx = Input.GetAxisRaw("Horizontal") * moveSpeed;
        // float dy = Input.GetAxisRaw("Vertical") * moveSpeed;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = incomingVelocity;
    }
}
