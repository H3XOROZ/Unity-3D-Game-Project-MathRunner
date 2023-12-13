using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollowPlayer : MonoBehaviour
{
    public Transform target; // เลือกผู้เล่นเป็นเป้าหมาย
    public float moveSpeed = 5.0f; // ความเร็วของ AI

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (target != null)
        {
            // หาเวกเตอร์ระหว่าง AI และผู้เล่น
            Vector3 moveDirection = target.position - transform.position;

            // หมุน AI ให้เห็นผู้เล่น
            transform.LookAt(target);

            // ขับเคลื่อน AI ไปที่ผู้เล่น
            rb.velocity = moveDirection.normalized * moveSpeed;
        }
    }
}
