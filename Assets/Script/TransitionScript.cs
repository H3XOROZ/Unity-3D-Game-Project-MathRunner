using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    public void MoveToNextScene()
    {
        // รีเซ็ตค่าเวลาใน PlayerPrefs
        PlayerPrefs.SetFloat("CurrentTime", 0f);

        // ย้ายไปยังหน้าต่อไป
        SceneManager.LoadScene("Win");
    }
}
