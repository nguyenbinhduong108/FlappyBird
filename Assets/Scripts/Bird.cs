using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float jumpForce;

    private void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    

    // Update is called once per frame
    void Update()
    {
        // Kiem tra phim space co duoc bam khong
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BirdMoveUp();
        }
    }

    private void BirdMoveUp() // bay len
    {
        rigidbody.velocity = Vector2.up * jumpForce;
    }
}
