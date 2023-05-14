using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerUp : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Up();
    }

    private void Up()
    {
        this.transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D target)
    {

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }
}
