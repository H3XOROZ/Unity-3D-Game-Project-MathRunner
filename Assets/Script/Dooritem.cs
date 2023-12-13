using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dooritem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip ItemSound;
    public AudioClip CompleteSound;

    int itemCount;
    private List<string> successTexts = new List<string> {
        "3,518 5,240",
        "2,672 2,414",
        "8,653 425",
        "15,600 11,900",
        "15,389 17,800",
        "25,389 14,821",
        "1,879 4,943" ,
        "6,921 2,699",
        "3,355 5,968",
        "สิ้นสุดด่าน",
        "ความสำเร็จ 10 / 9"
    };

    private void Start()
    {
        itemCount = GameObject.FindGameObjectsWithTag("Problems").Length;
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag.Equals("Problems") && score < 40)
        {
            Destroy(target.gameObject);
            score += 1;
            UpdateScoreText();

            if (score >= 40)
            {
                audioSource.PlayOneShot(CompleteSound);
                NextLevel();
            }
            else
            {
                audioSource.PlayOneShot(ItemSound);
            }
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene("Win");
    }

    void UpdateScoreText()
    {
        // ตรวจสอบให้แน่ใจว่ามีข้อความความสำเร็จสำหรับคะแนนนี้
        if (score < successTexts.Count)
        {
            scoreText.text = successTexts[score];
        }
    }
}
