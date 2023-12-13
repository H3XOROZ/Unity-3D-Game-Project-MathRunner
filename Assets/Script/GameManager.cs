using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject pauseUI;
    void Update()
    {
        scoretext.text = score.ToString();

        if (Input.GetKeyDown(KeyCode.Tab)){
            if (Time.timeScale == 1){
                Time.timeScale = 0;
                pauseUI.SetActive(true);
            }else {
                Time.timeScale = 1;
                pauseUI.SetActive(false);
            }
}
}   
    public AudioSource audioSource;
    public AudioClip ItemSound;

    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI buttonText1;
    public TextMeshProUGUI buttonText2;
    public TextMeshProUGUI buttonText3;
    public TextMeshProUGUI buttonText4;

    public string question = "";
    public string answer1 = "";
    public string answer2 = "";
    public string answer3 = "";
    public string answer4 = "";

    public int correctAnswer = -1;
    static public int score =0;

    void Start ()
    {
        questionText.text = question;
        buttonText1.text = answer1;
        buttonText2.text = answer2;
        buttonText3.text = answer3;
        buttonText4.text = answer4;
    }

    public void OnButton1Click()
    {
        if (correctAnswer ==1)
        {

            score++;
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);

        audioSource.PlayOneShot(ItemSound);
        
        }
        else
        {
            score = 0;
            SceneManager.LoadScene(5);
        }
    
    }

    
    public void OnButton2Click()
    {
        
        if (correctAnswer ==2)
        {

        score++;
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
        
        audioSource.PlayOneShot(ItemSound);
        }
        else
        {
            score = 0;
            SceneManager.LoadScene(5);
        }
        
    }

    public void OnButton3Click()
    {
        
        if (correctAnswer ==3)
        {

        score++;
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);

        audioSource.PlayOneShot(ItemSound);
        
        }
        else
        {
            score = 0;
            SceneManager.LoadScene(5);
        }
    
        
    }

    public void OnButton4Click()
    {
        
        if (correctAnswer ==4)
        {

        score++;
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
        
        audioSource.PlayOneShot(ItemSound);

        }
        else
        {
            score = 0;
            SceneManager.LoadScene(5);
        }
    
        }
    
}