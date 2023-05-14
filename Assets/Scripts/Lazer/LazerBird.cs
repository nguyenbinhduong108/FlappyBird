using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LazerBird : MonoBehaviour
{
    private bool levelStart;
    public GameObject gameController;
    public GameObject message;
    public float time;
    public Text timeText;
    public Text lastText;


    [SerializeField]
    private GameObject GameOverPanel;

    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1;
        levelStart = false;
        time = 0;
        message.GetComponent<SpriteRenderer>().enabled = true;
        GameOverPanel.SetActive(false);
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
                gameController.GetComponent<LazerGenerator>().enableGenerateLazer = true;
                message.GetComponent<SpriteRenderer>().enabled = false;
            }
            

        }

        if(levelStart == true) 
        {
            time += Time.deltaTime;
            timeText.text = time.ToString();
        }

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        SoundController.instance.PlayThisSound("lazer", 0.2f); 
        lastText.text = timeText.text;
        GameOverPanel.SetActive(true);
        time = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundController.instance.PlayThisSound("lazer", 0.2f);
    }

    public void btnReplay()
    {
        SceneManager.LoadScene("lazerScene");
    }


    public void btnMenu()
    {
        SceneManager.LoadScene("menuScene");
    }
}
