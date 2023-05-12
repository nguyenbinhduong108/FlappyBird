
using System.Collections;
using System.Collections.Generic;
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

    private void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        gameStart = false;
        rigidbody.gravityScale = 0;
        score = 0;
        
        
    }



    // Update is called once per frame
    void Update()
    {
        // Kiem tra phim space co duoc bam khong
        if (Input.GetKeyDown(KeyCode.Space))
        {
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
        ReloadScene();
        score = 0;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score += 1;
        scoreText.text = score.ToString();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene("mainScene");
    }
}
