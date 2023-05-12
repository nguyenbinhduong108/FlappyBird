
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float jumpForce;
    private bool gameStart;
    public GameObject gameController;
    private int score;
    public Text scoreText;
    public Text lastText;
    [SerializeField]
    private GameObject GameOverPannel;

    private void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        gameStart = false;
        rigidbody.gravityScale = 0;
        score = 0;
        
        GameOverPannel.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        // Kiem tra phim space co duoc bam khong
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundController.instance.PlayThisSound("wing", 0.2f);
            if (gameStart == false)
            {
                gameStart = true;
                rigidbody.gravityScale = 6;
                gameController.GetComponent<PipeGenerator>().enablePipe = true;

            }
            BirdMoveUp();
        }
    }

    private void BirdMoveUp() // bay len
    {
        rigidbody.velocity = Vector2.up * jumpForce;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        SoundController.instance.PlayThisSound("hit", 0.2f);
        lastText.text = scoreText.text;
        GameOverPannel.SetActive(true);
        
        score = 0;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundController.instance.PlayThisSound("point", 0.2f);
        score += 1;
        scoreText.text = score.ToString();
    }
    public void btnReplay()
    {
        SceneManager.LoadScene("mainScene");
    }
}
