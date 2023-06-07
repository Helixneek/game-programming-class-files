using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShellMenuManager : MonoBehaviour
{
    private IMenu SMC;
    
    private void Awake()
    {
        SMC = FindObjectOfType<SettingMenuController>();
    }

    public void StartGame(string sceneName)
    {
       SceneManager.LoadScene(sceneName);
    }

    public void OpenSettings()
    {
        SMC.Show();
    }

    public void CloseSettings()
    {
        SMC.Hide();
    }
}
