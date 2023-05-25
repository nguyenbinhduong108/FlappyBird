using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarBird : MonoBehaviour
{
    private bool levelStart;

    public GameObject gameController;

    public int lives = 3;

    public Image[] liveUI;

    public int score;

    public Text scoreText;

    public Text lastText;

    public GameObject message;

    [SerializeField]
    private GameObject GameOverPanel;

    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1f;
        levelStart = false;
        score = 0;
        message.GetComponent<SpriteRenderer>().enabled = true;
        GameOverPanel.SetActive(false);
        liveUI[0].enabled = false;
        liveUI[1].enabled = false;
        liveUI[2].enabled = false;
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (levelStart == false)
            {
                levelStart = true;
                gameController.GetComponent<StarBombGenerator>().enableGenerateStarBomb = true;
                message.GetComponent<SpriteRenderer>().enabled = false;
                liveUI[0].enabled = true;
                liveUI[1].enabled = true;
                liveUI[2].enabled = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        SoundController.instance.PlayThisSound("explosion", 0.2f);
        lastText.text = scoreText.text;
        GameOverPanel.SetActive(true);
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Star")
        {
            SoundController.instance.PlayThisSound("point", 0.2f);
            Destroy(collision.gameObject);
            score++;
        }

        if(collision.tag == "StarRanbow")
        {
            SoundController.instance.PlayThisSound("bonus", 0.2f);
            Destroy(collision.gameObject);
            score += 5;
        }

        if(collision.tag == "StarFire")
        {
            SoundController.instance.PlayThisSound("uh", 0.2f);
            Destroy(collision.gameObject);
            lives--;
            for(int i = 0; i< liveUI.Length; i++)
            {
                if(i < lives)
                {
                    liveUI[i].enabled = true;
                }
                else
                {
                    liveUI[i].enabled = false;
                }
            }
            if(lives <= 0)
            {
                Time.timeScale = 0f;
                lastText.text = scoreText.text;
                GameOverPanel.SetActive(true);
            }
        }
        
        scoreText.text = score.ToString();
    }

    public void btnReplay()
    {
        SceneManager.LoadScene("starScene");
    }

    public void btnMenu()
    {
        SceneManager.LoadScene("menuScene");
    }
}
