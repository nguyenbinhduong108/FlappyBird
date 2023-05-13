using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBombGenerator : MonoBehaviour
{

    public GameObject star;

    public GameObject bomb;

    public GameObject starRanbow;

    public GameObject starFire;

    private float countdown;

    public float timeDuration;

    public bool enableGenerateStarBomb;

    public int gen;

    



    private void Awake()
    {
        countdown = 0f;
        enableGenerateStarBomb = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enableGenerateStarBomb == true)
        {
            gen = Random.Range(1, 16);

            countdown -= Time.deltaTime;

            if (countdown <= 0)
            {
                if (gen >= 1 && gen <= 8)
                {
                    Instantiate(star, new Vector3(Random.Range(-6.7f, 6.7f), 6, 0), Quaternion.identity);
                }
                if (gen >= 9 && gen <= 12)
                {

                    Instantiate(bomb, new Vector3(Random.Range(-6.7f, 6.7f), 6, 0), Quaternion.identity);
                }

                if(gen >= 13 && gen <= 14)
                {
                    Instantiate(starFire, new Vector3(Random.Range(-6.7f, 6.7f), 6, 0), Quaternion.identity);
                }

                if( gen == 15)
                {
                    Instantiate(starRanbow, new Vector3(Random.Range(-6.7f, 6.7f), 6, 0), Quaternion.identity);
                }

                if(timeDuration >= 0.1)
                {
                    timeDuration -= Time.deltaTime * 3;
                }

                countdown = timeDuration;
            }  
        
            

        }
    }
}
