using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay1 : MonoBehaviour
{
    public Text timerText;

    void Start()
    {
        // ดึงค่าที่บันทึกไว้ใน PlayerPrefs (หากมี)
        if (PlayerPrefs.HasKey("CurrentTime"))
        {
            float timerCount = PlayerPrefs.GetFloat("CurrentTime");
            timerText.text = timerCount.ToString("F2"); // แสดงค่าที่อยู่ใน PlayerPrefs ในรูปแบบทศนิยม 2 ตำแหน่ง
        }
    }

    void Update()
    {
        // ตรวจสอบการกดปุ่มหรือเหตุการณ์อื่น ๆ และอัปเดตค่า timerCount
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ตัวอย่าง: เพิ่มค่า timerCount เมื่อกด Space
            float timerCount = PlayerPrefs.GetFloat("CurrentTime");
            timerCount += Time.deltaTime; // เพิ่ม timerCount ที่อยู่ใน PlayerPrefs ตามเวลา
            PlayerPrefs.SetFloat("CurrentTime", timerCount);
            PlayerPrefs.Save(); // บันทึกข้อมูล PlayerPrefs
        }
    }
}
