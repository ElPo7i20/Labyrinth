using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - ball.transform.position;
    }
    private void Update()
    {
        transform.position = ball.transform.position + offset;
    }
}
