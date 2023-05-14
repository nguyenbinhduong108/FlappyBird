using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGenerator : MonoBehaviour
{

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    public GameObject freezeUp;
    public GameObject freezeDown;
    public GameObject freezeLeft;
    public GameObject freezeRight;

    public float coutdown;

    public float timeDuration;

    public bool enableGenerateLazer;

    public int lazer;

    public int gen;

    public float count = 10f;

    private void Awake()
    {
        coutdown = 0f;
        enableGenerateLazer = false;
    }


    // Update is called once per frame
    void Update()
    {

        if (enableGenerateLazer == true) 
        {

            lazer = Random.Range(1, 5);
            // lazer = 1,2,3 thi sinh ra dan do
            // lazer = 4     thi sinh ra dan xanh

            gen = Random.Range(1,5);

            // 1 ban tu tren xuong
            // 2 ban thu trai sang
            // 3 ban tu duoi len
            // 4 ban tu phai sang

            coutdown -= Time.deltaTime * 2.5f;

            if(coutdown <= 0f)
            {
                if(lazer <= 3)
                {
                    if (gen == 1)
                    {
                        Instantiate(up, new Vector3(Random.Range(-6.7f, 6.7f), 6, 0), Quaternion.identity);
                    }

                    if (gen == 2)
                    {
                        Instantiate(left, new Vector3(-12, Random.Range(-4f, 4f), 0), Quaternion.identity);
                    }

                    if (gen == 3)
                    {
                        Instantiate(down, new Vector3(Random.Range(-6.7f, 6.7f), -6, 0), Quaternion.identity);
                    }

                    if (gen == 4)
                    {
                        Instantiate(right, new Vector3(12, Random.Range(-4f, 4f), 0), Quaternion.identity);
                    }
                }

                if(lazer == 4)
                {
                    if (gen == 1)
                    {
                        Instantiate(freezeUp, new Vector3(Random.Range(-6.7f, 6.7f), 6, 0), Quaternion.identity);
                    }

                    if (gen == 2)
                    {
                        Instantiate(freezeLeft, new Vector3(-12, Random.Range(-4f, 4f), 0), Quaternion.identity);
                    }

                    if (gen == 3)
                    {
                        Instantiate(freezeDown, new Vector3(Random.Range(-6.7f, 6.7f), -6, 0), Quaternion.identity);
                    }

                    if (gen == 4)
                    {
                        Instantiate(freezeRight, new Vector3(12, Random.Range(-4f, 4f), 0), Quaternion.identity);
                    }
                }

                coutdown = timeDuration;
            }
            
        }
    }
}
