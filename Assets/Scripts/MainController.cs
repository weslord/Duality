using UnityEngine;

public class MainController : MonoBehaviour
{
    public OtherController follower;

    public float moveSpeed = 75f;
    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        float dx = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float dy = Input.GetAxisRaw("Vertical") * moveSpeed;
        Vector2 v = new Vector2(dx, dy);

        // NOTE: this does not work well.
        follower.incomingVelocity = rb.velocity; // send old velocity out

        rb.velocity = v;
    }
}
