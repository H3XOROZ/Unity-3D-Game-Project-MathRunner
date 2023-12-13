using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        // ดึงค่า score จาก PlayerPrefs
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        // แสดงค่า score ใน Text ในหน้า "Win"
        scoreText.text = "คะแนน: " + finalScore.ToString();
    }
}
