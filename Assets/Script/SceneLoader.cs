using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // ชื่อแมพที่ต้องการโหลด
    public GameObject loadingScreen; // อ้างอิงถึง GameObject ของหน้า Loading
    public Slider loadingSlider; // (ถ้ามี) อ้างอิงถึง Slider ที่ใช้แสดงเวลาการโหลด

    public void LoadScene()
    {
        StartCoroutine(LoadSceneAsync());
    }

    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        if (loadingScreen != null)
            loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f); // ป้องกันการหยุดโหลดที่ 90%
            if (loadingSlider != null)
                loadingSlider.value = progress;

            yield return null;
        }
    }
}
