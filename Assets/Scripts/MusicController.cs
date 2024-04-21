using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public List<AudioSource> musicSources;
    public static bool isFight = false;
    public static bool isSuspense = false;
    public static bool isDefault = true;

    void Start()
    {
        EnableMusic();
        musicSources[0].Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDefault)
        {
            EnableMusic();
            musicSources[0].Play();
        }
        else if (isFight)
        {
            EnableMusic();
            musicSources[1].Play();
        }
        else if (isSuspense)
        {
            EnableMusic();
            musicSources[2].Play();
        }
    }

    private void EnableMusic()
    {
        foreach (AudioSource music in musicSources)
        {
            music.Pause();
        }
    }
}
