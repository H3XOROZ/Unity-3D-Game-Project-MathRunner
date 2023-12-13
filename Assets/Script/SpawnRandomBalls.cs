using UnityEngine;

public class SpawnRandomBalls : MonoBehaviour
{
    public GameObject ballPrefab1; // โปรไฟล์ของลูกบอลประเภท 1
    public GameObject ballPrefab2; // โปรไฟล์ของลูกบอลประเภท 2
    public int numberOfBalls = 150; // จำนวนลูกบอลที่ต้องการสร้าง

    private int currentBallIndex = 0;
    private GameObject newBall; // เพิ่มตัวแปร newBall ที่นี่
    private Vector3 randomPosition; // เพิ่มตัวแปร randomPosition ที่นี่

    void Start()
    {
        SpawnNextBall();
    }

    void SpawnNextBall()
    {
        if (currentBallIndex < numberOfBalls)
        {
            randomPosition = new Vector3(
                Random.Range(-8.7f, 10.41f),
                19.26f,
                55.10244f
            );

            // สลับการสร้างลูกบอลประเภท 1 และ 2 โดยใช้ Random.Range
            int randomType = Random.Range(0, 2);
            if (randomType == 0)
            {
                newBall = Instantiate(ballPrefab1, randomPosition, Quaternion.identity);
            }
            else
            {
                newBall = Instantiate(ballPrefab2, randomPosition, Quaternion.identity);
            }

            currentBallIndex++;

            // รอสั้นๆ ก่อนที่จะสร้างลูกถัดไป
            float delay = 0.2f; // ปรับค่าตามความต้องการ
            Invoke("SpawnNextBall", delay);
        }
    }

    void Update()
    {
        // เมื่อลูกบอลออกนอกหน้าจอในแกน X
        if (newBall != null && (newBall.transform.position.x < -60f || newBall.transform.position.x > 60f))
        {
            // สุ่มค่า X ใหม่และใช้ตำแหน่ง Y และ Z เดิม
            randomPosition = new Vector3(
                Random.Range(-8.7f, 10.41f),
                randomPosition.y,
                randomPosition.z
            );

            // กำหนดตำแหน่งใหม่ให้กับลูกบอล
            newBall.transform.position = randomPosition;
        }
    }
}
