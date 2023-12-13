using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour

{
    public static bool GameIsPaused = true;
    public GameObject pauseMenuUI;
    

    void Update() 
    
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                Pause();
                
            }else 
            {
                Resume();
                
            }
        }
    }

    void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        
    }

    public void restart_game()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
            GameIsPaused = false;

        }

        public void main_menu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }






}