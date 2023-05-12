using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundController instance;
    private void Awake()
    {
        instance = this;
    }

    public void PlayThisSound(string clipName, float volumn)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.volume *= volumn;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Sound/" + clipName, typeof (AudioClip)));
    }
    
}
