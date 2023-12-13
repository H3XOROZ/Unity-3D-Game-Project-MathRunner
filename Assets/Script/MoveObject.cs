using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 5.0f; // ความเร็วของการย้าย
    public Vector3[] positions = new Vector3[16]; // อาร์เรย์ของตำแหน่งทั้งหมด
    private int currentPositionIndex = 0;
    private int dButtonCount = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentPositionIndex = GetNextEvenPosition(currentPositionIndex);
            dButtonCount++;

            if (dButtonCount == 5)
            {
                currentPositionIndex = 10;
                dButtonCount = 0;
            }
            MoveToNextPosition();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            currentPositionIndex = GetNextOddPosition(currentPositionIndex);
            MoveToNextPosition();
        }
    }

    int GetNextEvenPosition(int currentIndex)
    {
        int nextIndex = currentIndex + 1;
        while (nextIndex < positions.Length && nextIndex % 2 != 0)
        {
            nextIndex++;
        }
        return nextIndex;
    }

    int GetNextOddPosition(int currentIndex)
    {
        int nextIndex = currentIndex + 1;
        while (nextIndex < positions.Length && nextIndex % 2 == 0)
        {
            nextIndex++;
        }
        return nextIndex;
    }

    void MoveToNextPosition()
    {
        if (currentPositionIndex >= 0 && currentPositionIndex < positions.Length)
        {
            transform.position = positions[currentPositionIndex];
        }
    }
}
