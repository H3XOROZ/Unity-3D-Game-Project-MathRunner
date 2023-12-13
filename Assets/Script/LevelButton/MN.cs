using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MN : MonoBehaviour
{
    public string sceneName; // ชื่อของด่านที่ต้องการเปลี่ยนไป
    public Button changeSceneButton; // ระบุปุ่มที่จะใช้เปลี่ยนด่าน

    private void Start()
    {
        // เพิ่ม Listener เพื่อเรียกใช้งานฟังก์ชัน ChangeToScene เมื่อปุ่มถูกคลิก
        changeSceneButton.onClick.AddListener(ChangeToScene);
    }
    public void ChangeToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
