using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        // ควบคุมการเคลื่อนที่ด้วยลูกศรบนคีย์บอร์ด
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
