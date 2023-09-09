using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveManager : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.left * moveSpeed;
    }
}
