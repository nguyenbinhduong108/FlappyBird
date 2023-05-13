using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;

    private void Awake()
    {
        pausePanel.SetActive(false);
    }

    private void Update()
    {
        Stop();
    }

    public void Stop()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("menuScene");
    }
}
