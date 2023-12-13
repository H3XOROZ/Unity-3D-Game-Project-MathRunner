using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camintro : StateMachineBehaviour
{

    public Animation cameraAnimation; // Reference to the camera animation
    public string nextSceneName; // The name of the scene to load next

    public void LoadNextScene()
    {
        // Play the camera animation
        cameraAnimation.Play();

    }

    private void LoadScene()
    {
        SceneManager.LoadScene(6);
    }


}
