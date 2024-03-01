using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void NewGameOrRetry()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
