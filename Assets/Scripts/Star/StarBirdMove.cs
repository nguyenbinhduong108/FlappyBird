using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBirdMove : MonoBehaviour
{
    public float move;

    public float speed;

    private bool isFacingRight = true;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            move = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            move = 1;
        }
        else
        {
            move = 0;
        }

        flip();

        if ((transform.position.x <= -8.5f && move < 0) ||
            (transform.position.x >= 8.5f && move>0))
            return;

        transform.Translate(Vector3.right * speed * move * Time.deltaTime);
    }

    

    void flip()
    {
        if((isFacingRight && move < 0) || (!isFacingRight && move > 0))
        {
            isFacingRight = !isFacingRight;
            Vector3 size = transform.localScale;
            size.x *= -1;
            transform.localScale = size;
        }
    }

}
