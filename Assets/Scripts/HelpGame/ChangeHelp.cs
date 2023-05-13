using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeHelp : MonoBehaviour
{
    public void changeHelp1()
    {
        SceneManager.LoadScene("Help1");
    }

    public void changeHelp2()
    {
        SceneManager.LoadScene("Help2");    
    }

    public void changeHelp3()
    {
        SceneManager.LoadScene("Help3");
    }

    
}
