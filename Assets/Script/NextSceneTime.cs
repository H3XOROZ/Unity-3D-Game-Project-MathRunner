using UnityEngine;
using UnityEngine.UI;

public class NextSceneTime : MonoBehaviour
{
    public Text timeRemainingText; // ใช้ Text ในการแสดงเวลาที่เหลือ

    private void Start()
    {
        // ดึงค่าเวลาปัจจุบันจาก PlayerPrefs
        float currentTime = PlayerPrefs.GetFloat("CurrentTime", 0f);

        // แสดงเวลาที่เหลือ
        timeRemainingText.text = "เหลือเวลา : " + currentTime.ToString("0.00");
    }
}
