using UnityEngine;
using UnityEngine.UI;

public class PanelController1 : MonoBehaviour
{
    public GameObject panel; // ตัวแปรสำหรับเก็บอ็อบเจกต์ของ panel

    public void ActivatePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false); // เปลี่ยนค่า panel เป็น true เมื่อกดรูปภาพ
            Time.timeScale = 1;
        }
    }
}
