using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    private Vector3 direction = Vector3.zero;

    public float MoveSpeed => moveSpeed;

    private void Update()
    {
        transform.position += moveSpeed * direction * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction) 
    {
        this.direction = direction;
    }
}
