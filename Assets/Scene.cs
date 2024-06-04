using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void FirstLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
