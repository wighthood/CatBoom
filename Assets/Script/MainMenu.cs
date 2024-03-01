using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject m_Credits;
    [SerializeField] private GameObject m_Menu;
    [SerializeField] private GameObject m_Settings;

    public void OnPlayBtn()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void OnCreditsBtn()
    {
        m_Menu.SetActive(false);
        m_Credits.SetActive(true);
        Debug.Log("ggg");
    }

    public void OnSettingsBtn()
    {
        m_Menu.SetActive(false);
        m_Settings.SetActive(true);
    }

    public void OnLeaveBtn()
    {
        Application.Quit();
    }

}
