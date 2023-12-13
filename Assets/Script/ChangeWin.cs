using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeWin : MonoBehaviour
{
    public AudioClip CompleteSound;
    public string sceneName;
    public GameObject panelToOpen; // กำหนดให้เป็น GameObject ของ Panel ที่คุณต้องการเปิด

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            
            StartCoroutine(LoadSceneWithDelay(sceneName, 5f));
            Time.timeScale = 0f;
        }
    }

    IEnumerator LoadSceneWithDelay(string sceneName, float delay)
    {
        // เปิด Panel ก่อนรอเวลา
        panelToOpen.SetActive(true);

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
