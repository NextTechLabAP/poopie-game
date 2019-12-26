using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplayCotroller : MonoBehaviour
{
    public static bool canPlayAudio = true;
    public static bool death = false;
    public AudioSource ad;
    public AudioSource deathSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canPlayAudio)
        {
            ad.enabled = true;
        }
        else
        {
            ad.enabled = false;
        }
        if (death)
        {
            deathSound.enabled = true;
        }
    }
}
