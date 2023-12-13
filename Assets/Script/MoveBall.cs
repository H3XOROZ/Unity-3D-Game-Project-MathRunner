using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float minSpeed = 1f; // ความเร็วขั้นต่ำ
    public float maxSpeed = 5f; // ความเร็วสูงสุด

    private Vector3 initialPosition; // ตำแหน่งเริ่มต้น
    private Vector2 randomDirection; // ทิศทางการเคลื่อนที่สุ่มในแกน X และ Y
    private float speed; // ความเร็วปัจจุบัน

    void Start()
    {
        initialPosition = transform.position;
        randomDirection = Random.insideUnitCircle.normalized; // สุ่มทิศทางการเคลื่อนที่ในแกน X และ Y
        speed = Random.Range(minSpeed, maxSpeed); // สุ่มความเร็ว
    }

    void Update()
    {
        // ทำการเคลื่อนที่ตามทิศทางและความเร็วที่สุ่ม
        Vector3 movement = new Vector3(randomDirection.x, 0, randomDirection.y); // ไม่มีการเคลื่อนที่ในแกน Y
        transform.Translate(movement * speed * Time.deltaTime);

        // เมื่อลูกบอลออกนอกขอบเขต (เช่น, ถ้ามันไปห่างจากตำแหน่งเริ่มต้นมากกว่า 10 หน่วย), มันจะถูกส่งกลับไปยังตำแหน่งเริ่มต้นและสุ่มทิศทางและความเร็วใหม่.
        if (Vector3.Distance(new Vector3(transform.position.x, initialPosition.y, transform.position.z), initialPosition) > 60f)
        {
            transform.position = initialPosition;
            randomDirection = Random.insideUnitCircle.normalized;
            speed = Random.Range(minSpeed, maxSpeed);
        }
    }
}
