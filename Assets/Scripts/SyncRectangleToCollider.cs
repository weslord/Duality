using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes;

public class SyncRectangleToCollider : MonoBehaviour
{
    void OnValidate() {
        //TODO: find a better trigger for this?
        //      happens at various times, but not specifically when an edit has been performed

        BoxCollider2D bc = GetComponent<BoxCollider2D>();
        Rectangle r = GetComponent<Rectangle>();

        bc.size = new Vector2(r.Width, r.Height);
    }
}
