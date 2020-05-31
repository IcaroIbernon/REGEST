using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public void Awake()
    {
        GameObject sound = GameObject.Find("GameSound").gameObject;
        if (sound != null)
        {
            AudioSource audio = sound.GetComponent<AudioSource>();

            if (!audio.isPlaying)
            {
                audio.Play();
                DontDestroyOnLoad(sound);
            }
        }
    }
}
