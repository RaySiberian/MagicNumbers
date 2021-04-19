using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Public Methods

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadWinScene()
    {
        SceneManager.LoadScene(2);
    }
    
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExit()
    {
        Application.Quit();
    }
    
    #endregion
}
