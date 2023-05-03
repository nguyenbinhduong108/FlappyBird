using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         OnBecameInvisible();
    }
    void OnBecameInvisible() {
         if (transform.position.x <= -10)
         Destroy(gameObject);
    }
}
