using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiUses : MonoBehaviour
{

    public bool autoDestroy;
    public bool playRandomSound;

    public AudioSource source;
    public AudioClip[] sounds;

    public float destroyTime;

    // Start is called before the first frame update
    void Start()
    {
     
        if (autoDestroy == true)
        {

            Destroy(gameObject, destroyTime);

        }

        if (playRandomSound == true)
        {

            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();

        }

    }
}
