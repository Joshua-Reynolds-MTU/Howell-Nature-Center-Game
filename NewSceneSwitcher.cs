using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewSceneSwitcher : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void playGame()
    {
        SceneManager.LoadScene("SlidesScene");
    }
    
    public void starter()
    {
        SceneManager.LoadScene(sceneBuildIndex: 5);
    }
    
    public void invokeSwitcher()
    {
        int index = Random.Range(1, 5);
        SceneManager.LoadScene(index);
    }
    
    public void quitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    
    public void tenSecondBack()
    {
        SceneManager.LoadScene("SlidesScene");
    }
}
    
