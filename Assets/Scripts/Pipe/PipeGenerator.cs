using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipePrefab;

    private float countdown;

    public float timeDuration;

    public bool enableGeneratePipe; //cho phep sinh ra ong hay khong

    private void Awake()
    {  
        countdown = 0f;
        enableGeneratePipe = false;
    }

    // Update is called once per frame
    void Update() 
    {
        if (enableGeneratePipe == true) 
        {
            countdown -= Time.deltaTime; // moi frame countdown tru di 1 gia tri bang 1 / FPS

            if (countdown <= 0)
            {
                // sinh ra ong

                Instantiate(pipePrefab, new Vector3(12, Random.Range(-0.57f, 2.92f), 0), Quaternion.identity);

                countdown = timeDuration;
            }
        }
    }

    
}
