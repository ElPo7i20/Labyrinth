using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Vector2 TouchPosition()
    {
        if(Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }
        else
        {
            return Vector2.zero;
        }
    }
    public bool TouchOn()
    {
        if(Input.touchCount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void MoveBall()
    {
        Vector2 tocPos = TouchPosition();
        tocPos = tocPos * speed;
        Vector3 grPos = new Vector3(tocPos.x, Physics.gravity.y, tocPos.y);
        Physics.gravity = grPos;
    }
    private void Update()
    {
        MoveBall();
    }
}
