using UnityEngine;

public class RemoteCollider : MonoBehaviour
{
    public BoxCollider2D followThisCollider;
    new BoxCollider2D collider;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        collider.size = followThisCollider.size;
        collider.transform.position = followThisCollider.transform.position;
    }

     void FixedUpdate() {
        collider.transform.position = followThisCollider.transform.position;
    }
}
