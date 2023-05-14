using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBirdMove : MonoBehaviour
{

    public float speed;

    public float freezeTime = 5f;

    private bool isFacingRight = true;

    float moveHorizontal;

    float moveVertical;

   [SerializeField]
    private GameObject freezeEffect;

    void Start()
    {
        freezeEffect.SetActive(false);
    }

    private void Update()
    {
        if(speed == 6f)
        {
            freezeTime -= Time.deltaTime;
            freezeEffect.SetActive(true);
        }


        if(freezeTime <= 0)
        {
            speed = 12f;
            freezeTime = 5f;
            freezeEffect.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        float newX = Mathf.Clamp(transform.position.x + moveHorizontal * speed * Time.deltaTime, -8.3f, 8.3f);
        float newY = Mathf.Clamp(transform.position.y + moveVertical * speed * Time.deltaTime, -4.6f, 4.6f);

        transform.position = new Vector3(newX, newY, transform.position.z);

        flip(); //quay dau nhân vat

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Freeze")
        {
            speed = 6f;
            Destroy(collision.gameObject);
        }
        
    }

    void flip()
    {
        if((isFacingRight && moveHorizontal < 0) || (!isFacingRight && moveHorizontal > 0))
        {
            isFacingRight = !isFacingRight;
            Vector3 size = transform.localScale;
            size.x *= -1;
            transform.localScale = size;
        }
    }
}
