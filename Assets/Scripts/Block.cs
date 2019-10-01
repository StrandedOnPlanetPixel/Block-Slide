using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        //rigidbody = gameObject.AddComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void OnMouseDrag()
    {
        //transform.position = Input.mousePosition;
        rigidBody.MovePosition(Input.mousePosition);
    }

    // Y stays the same, X changes
    public void OnDragHorizontal()
    {
        xPos = Input.mousePosition.x;
        yPos = transform.position.y;
        //transform.position = new Vector2(xPos, yPos);
        rigidBody.MovePosition(new Vector2(xPos, yPos));
    }

    // X stays the same, Y changes
    public void OnDragVertical()
    {
        xPos = transform.position.x;
        yPos = Input.mousePosition.y;
        //transform.position = new Vector2(xPos, yPos);
        rigidBody.MovePosition(new Vector2(xPos, yPos));
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Entered: " + collision.ToString());
    }
}
