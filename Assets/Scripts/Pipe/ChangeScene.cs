using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int Date;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Date = DateTime.Now.Hour;
            Change();
        }
    }

    private void Change()
    {
        if (Date < 7 && Date >= 0 || Date >= 18 && Date < 24)
        {
            SceneManager.LoadScene("gamePlayNight");
            /*Debug.Log("Chuyen dem " + Date);*/
        }
        if (Date >= 7 && Date < 18)
        {
            SceneManager.LoadScene("gamePlayDay");
            /*Debug.Log("Chuyen ngay " + Date);*/
        }
    }

}

