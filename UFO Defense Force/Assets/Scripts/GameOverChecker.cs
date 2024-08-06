using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverChecker : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // Implement your game over logic here
        Debug.Log("Game Over");
        GameOverManager.isGameOver = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the current scene
    }
}
