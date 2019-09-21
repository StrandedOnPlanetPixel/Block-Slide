using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;

    public void OnMouseDrag()
    {
        transform.position = Input.mousePosition;

    }

    // Y stays the same, X changes
    public void OnDragHorizontal()
    {
        xPos = Input.mousePosition.x;
        yPos = transform.position.y;
        transform.position = new Vector3(xPos, yPos);
    }

    // X stays the same, Y changes
    public void OnDragVertical()
    {
        xPos = transform.position.x;
        yPos = Input.mousePosition.y;
        transform.position = new Vector3(xPos, yPos);
    }
}
