using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public void PressStart()
    {
        SceneManager.LoadScene("Level_Select");
    }
    
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void NextLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void NextLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
    
    public void NextLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
