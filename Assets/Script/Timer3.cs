using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer3 : MonoBehaviour
{
    public UnityEvent OnTimeStart;
    public UnityEvent OnTimeOut;
    public float startTime;
    public float timerCount;
    public bool isStartTimer = false;

    private void Start()
    {
        StartTimer(); // เริ่มต้นการนับเวลาเมื่อทำการเริ่มเกม
    }

    private void StartTimer()
    {
        OnTimeStart.Invoke();

        isStartTimer = true;
        timerCount = startTime;

        // เก็บเวลาใน PlayerPrefs
        PlayerPrefs.SetFloat("CurrentTime", timerCount);
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            // ย้ายหน้าจอหรือหยุดแอพ, หยุดเวลาและบันทึกเวลาใน PlayerPrefs
            isStartTimer = false;
            PlayerPrefs.SetFloat("CurrentTime", timerCount);
        }
        else
        {
            // กลับมาที่แอพ, เริ่มต้นการนับเวลาใหม่
            StartTimer();
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

                // อัพเดตค่าเวลาใน PlayerPrefs
                PlayerPrefs.SetFloat("CurrentTime", timerCount);
            }
        }
    }
}
