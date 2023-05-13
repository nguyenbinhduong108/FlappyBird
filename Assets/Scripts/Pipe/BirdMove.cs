using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SoundController.instance.PlayThisSound("wing", 0.2f);
            BirdMoveUp();
        }
        
    }

    private void BirdMoveUp() // bay len
    {
        rigidbody.velocity = Vector2.up * jumpForce;
    }
}
