using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private bool levelStart;
    public GameObject gameController;
    public int score;
    public Text scoreText;
    public Text lastText;

    [SerializeField]   
    private GameObject GameOverPanel;
    

    private void Awake()
    {
        Time.timeScale = 1f;
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        levelStart = false;
        rigidbody.gravityScale = 0;
        score = 0;
        GameOverPanel.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        // Kiem tra phim space co duoc bam khong
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (levelStart == false)
            {
                levelStart = true;
                rigidbody.gravityScale = 6;
                gameController.GetComponent<PipeGenerator>().enableGeneratePipe = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        SoundController.instance.PlayThisSound("hit", 0.2f);
        lastText.text = scoreText.text;
        GameOverPanel.SetActive(true);
        score = 0;

    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundController.instance.PlayThisSound("point", 0.2f);
        score++;
        scoreText.text = score.ToString();
    }

    public void btnReplay()
    {
        SceneManager.LoadScene("mainScene");
    }


    public void btnMenu()
    {
        SceneManager.LoadScene("menuScene");
    }
    

}
