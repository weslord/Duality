using UnityEngine;

public class MainController : MonoBehaviour
{
    public float moveSpeed = 75f;

    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        float dx = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float dy = Input.GetAxisRaw("Vertical") * moveSpeed;
        Vector2 v = new Vector2(dx, dy);

        rb.velocity = v;
    }
}
