using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dooritem1 : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip ItemSound;
    public AudioClip CompleteSound;

    int itemCount;
    private List<string> successTexts = new List<string> {
        "7,459 2,351",
        "1,550 1,335",
        "2,482 880",
        "3,204 685",
        "5,006 8,377",
        "608 249",
        "734 669",
        "6,230 3,910",
        "6,921 2,699",
        "5,355 2,968",
        "เข้าเส้นชัย",
        "ความสำเร็จ 10 / 9"
    };

    private void Start()
    {
        itemCount = GameObject.FindGameObjectsWithTag("Problems").Length;
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag.Equals("Problems") && score < 9)
        {
            Destroy(target.gameObject);
            score += 1;
            UpdateScoreText();

            if (score >= 9)
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
