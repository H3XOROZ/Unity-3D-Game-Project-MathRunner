using UnityEngine;

public class GameControl : MonoBehaviour
{
    private bool panelActive = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            panelActive = true;
            Time.timeScale = 0f; // หยุดการเคลื่อนไหวในเกม
            // สามารถเรียกใช้ฟังก์ชันอื่นเพื่อแสดง panel หรือทำการจัดการการหยุดเกมเพิ่มเติมได้ที่นี่
        }
    }
}
