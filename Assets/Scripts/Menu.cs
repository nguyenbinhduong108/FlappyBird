using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void mainScene()
    {
        SceneManager.LoadScene("mainScene");
    }

    public void starScene()
    {
        SceneManager.LoadScene("starScene");
    }

    public void lazerScene()
    {
        SceneManager.LoadScene("lazerScene");
    }
    public void helpScene()
    {
        SceneManager.LoadScene("Help1");
    }
}
