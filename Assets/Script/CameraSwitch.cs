using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Transform camera2; // กำหนด GameObject ของ camera2 ที่ต้องการให้ย้ายไป
    public GameObject camera1; // กำหนด GameObject ของ camera1 ที่ต้องการลบ

    private void Start()
    {
        // เริ่มการรอเวลา 6 วินาทีเพื่อสลับกล้องไปยัง "camera2"
        Invoke("SwitchCamera", 1.9f);
    }

    // ฟังก์ชันเพื่อย้ายกล้องไปยัง camera2 และลบ camera1
    private void SwitchCamera()
    {
        // ปิด "camera1" โดยการเปลี่ยนเป็น false
        camera1.SetActive(false);

        // เปิด "camera2" โดยการเปลี่ยนเป็น true
        camera2.gameObject.SetActive(true);

        // ลบ "camera1"
        Destroy(camera1);
    }
}
