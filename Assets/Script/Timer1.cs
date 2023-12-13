using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
    public UnityEvent OnTimeStart;
    public UnityEvent OnTimeOut;
    public float startTime;
    public float timerCount;

    public bool isStartTimer = false;
    public Text timerText; // ตัวแปร Text สำหรับแสดงค่าเวลา
    private Coroutine displayPlayerPrefsCoroutine; // Coroutine สำหรับแสดงค่า PlayerPrefs

    void Start()
    {
        StartTimer(); // เรียกฟังก์ชัน StartTimer() เมื่อเริ่มเกม
    }

    public void StartTimer()
    {
        OnTimeStart.Invoke();
        isStartTimer = true;
        timerCount = startTime;

        // เก็บเวลาปัจจุบันใน PlayerPrefs
        PlayerPrefs.SetFloat("CurrentTime", timerCount);

        // เริ่ม Coroutine สำหรับแสดงค่า PlayerPrefs
        if (displayPlayerPrefsCoroutine == null)
        {
            displayPlayerPrefsCoroutine = StartCoroutine(DisplayPlayerPrefsValue());
        }
    }

    private IEnumerator DisplayPlayerPrefsValue()
    {
        while (true)
        {
            if (timerText != null)
            {
                if (timerText.enabled) // ตรวจสอบค่า timerText.enabled
                {
                    float storedTime = PlayerPrefs.GetFloat("CurrentTime", 0f); // อ่านค่า PlayerPrefs
                    timerText.text = storedTime.ToString("F0"); // แสดงค่าใน Text UI
                }
            }
            yield return new WaitForSeconds(1f); // รอ 1 วินาที
        }
    }

    private void StopDisplayPlayerPrefsCoroutine()
    {
        if (displayPlayerPrefsCoroutine != null)
        {
            StopCoroutine(displayPlayerPrefsCoroutine);
            displayPlayerPrefsCoroutine = null;
        }
    }

    private void FixedUpdate()
    {
        if (timerCount > 0 && isStartTimer)
        {
            timerCount -= Time.deltaTime;
            if (timerCount <= 0)
            {
                OnTimeOut.Invoke();
            }

            // อัพเดตค่าเวลาใน PlayerPrefs
            PlayerPrefs.SetFloat("CurrentTime", timerCount);
        }
    }
}
