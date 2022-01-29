using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OtherController : MonoBehaviour
{
    float MOVE_SPEED = 0.1f;

    void Update() {
        float dx = Input.GetAxisRaw("Horizontal") * MOVE_SPEED;
        float dy = Input.GetAxisRaw("Vertical") * MOVE_SPEED;
        transform.position = new Vector3(transform.position.x + dx, transform.position.y + dy, transform.position.z);
    }
}
