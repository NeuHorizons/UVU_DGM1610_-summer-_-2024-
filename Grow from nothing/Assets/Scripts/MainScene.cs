using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainScene : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
