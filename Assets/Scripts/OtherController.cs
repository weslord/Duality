using UnityEngine;

public class OtherController : MonoBehaviour
{
    public float moveSpeed = 75f;

    void FixedUpdate() {
        float dx = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float dy = Input.GetAxisRaw("Vertical") * moveSpeed;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(dx, dy);
    }
}
