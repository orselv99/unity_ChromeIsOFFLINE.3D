using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    private AudioSource bgm = null;
    private AudioSource[] sfxes = null;
    private int next = 0;
    private AudioClip[] hitClip = null;

    private void Awake()
    {
        this.bgm = GetComponent<AudioSource>();
        this.bgm.Play();

        this.sfxes = GetComponentsInChildren<AudioSource>();

        instance = this;
    }

    static void BGMStart()
    {
        instance.bgm.Play();
    }

    static void PlayAudio()
    {
        
    }

}
