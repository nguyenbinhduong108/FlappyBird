using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PipeGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    private float countdown;
    public float timeDuration;
    public bool enablePipe;

    private void Awake()
    {
        countdown = 0f;
        enablePipe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enablePipe == true)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                Instantiate(pipePrefab, new Vector3(10, Random.Range(-2.5f, -0.5f), 0), Quaternion.identity);
                countdown = timeDuration;
            }
        }
    }
}
