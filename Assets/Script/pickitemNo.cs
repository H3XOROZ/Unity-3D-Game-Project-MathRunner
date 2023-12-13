using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pickitemNo : MonoBehaviour
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
        itemCount = GameObject.FindGameObjectsWithTag("Not Item").Length;
        scoreText.text = "ผิด / " + score.ToString();
        
}

private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag.Equals("Not Item"))
    {
        Destroy(target.gameObject);
        score += 1;
            scoreText.text = "ผิด /  " + score.ToString();

            if (score>= 3)
            {
                audioSource.PlayOneShot(CompleteSound);

                NextLevel();
            }else{
                audioSource.PlayOneShot(ItemSound);
            }
}
}

    void NextLevel()
    {
        SceneManager.LoadScene("Lose");
    }
}