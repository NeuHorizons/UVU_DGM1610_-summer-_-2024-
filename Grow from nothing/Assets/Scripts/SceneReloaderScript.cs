using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public void ReloadScene()
    {
        // Get the name of the current active scene
        string currentSceneName = SceneManager.GetActiveScene().name;
        // Load the current scene
        SceneManager.LoadScene(currentSceneName);
    }
}
