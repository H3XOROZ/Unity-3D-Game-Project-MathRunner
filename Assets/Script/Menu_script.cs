using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_script : MonoBehaviour
{

        public void Level1_game()
        {
            SceneManager.LoadScene(2);
            Time.timeScale = 1f;

        }
          public void Level2_game()
        {
            SceneManager.LoadScene(3);
            Time.timeScale = 1f;

        }
          public void Level3_game()
        {
            SceneManager.LoadScene(4);
            Time.timeScale = 1f;

        }
          public void Level4_game()
        {
            SceneManager.LoadScene(5);
            Time.timeScale = 1f;

        }
        public void Level5_game()
        {
            SceneManager.LoadScene(19);
            Time.timeScale = 1f;

        }
        public void Level6_game()
        {
            SceneManager.LoadScene(21);
            Time.timeScale = 1f;

        }
        public void chooseLevel_game()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
        public void chooseLevel2_game()
        {
            SceneManager.LoadScene(20);
            Time.timeScale = 1f;
        }

        public void Leveltutorial_game()
        {
            SceneManager.LoadScene(17);
            Time.timeScale = 1f;

        }
        public void StopManu()
        {
            SceneManager.LoadScene(22);
            Time.timeScale = 1f;

        }

        public void exit_game()
        {
            Application.Quit();
        }

        

        public void start_game()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }

        public void RestartGame()
{
    int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1; // หากต้องการโหลด scene ก่อนหน้าให้ลบ 1 จาก build index ของ scene ปัจจุบัน

    if (previousSceneIndex >= 0)
    {
        SceneManager.LoadScene(previousSceneIndex);
        Time.timeScale = 1f;
    }
    else
    {
        // ไม่มี scene ก่อนหน้า ถ้า scene ปัจจุบันคือ scene 0 หรือไม่มี scene ใดๆ ที่สามารถโหลดกลับไป
        Debug.Log("ไม่สามารถโหลด scene ก่อนหน้าได้");
    }
}

        public void main_menu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }

        public void ouit_to_menu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }
        
}
