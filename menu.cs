using System.Collections; using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public string levelName;
    public void quit()
    {
        Application.Quit();
    }
    public void openLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
