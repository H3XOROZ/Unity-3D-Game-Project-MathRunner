using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pickitem1 : MonoBehaviour
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
        scoreText.text = "ความสำเร็จ 5 / " + score.ToString();
        
}

private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag.Equals("Item"))
    {
        Destroy(target.gameObject);
        score += 1;
            scoreText.text = "ความสำเร็จ 5 /  " + score.ToString();

            if (score>= 5)
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
        SceneManager.LoadScene("Win");
    }
}