﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GameObject;

public class AudioControl : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(transform.gameObject);
        //_audioSource = GetComponent<AudioSource>();
    }
    /*
    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
    */
}
