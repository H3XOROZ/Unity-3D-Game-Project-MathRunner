using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pickitem2 : MonoBehaviour
{
private int score = 0;
public Text scoreText;
private AudioSource audioSource;
public AudioClip ItemSound;

public AudioClip CompleteSound;


    int itemCount;
private void Start()
{
    audioSource = GetComponent<AudioSource>();
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = "ถูก / " + score.ToString();
        
}

private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag.Equals("Item"))
    {
        Destroy(target.gameObject);
        score += 1;
            scoreText.text = "ถูก / " + score.ToString();

            if (score>= 11)
            {
                audioSource.PlayOneShot(CompleteSound);
                PlayerPrefs.SetInt("FinalScore", score);

                NextLevel();
            }else{
                audioSource.PlayOneShot(ItemSound);
            }
}
}

    void NextLevel()
    {
        SceneManager.LoadScene("Win");
    }
}