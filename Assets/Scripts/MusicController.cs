using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public List<AudioSource> musicSources;//0:default,1:fight,2:suspense
    public static int currentIndex;

    void Start()
    {
        currentIndex = 0;
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        PlayMusic();
    }

    private void PlayMusic()
    {
        foreach (AudioSource music in musicSources)
        {
            music.Pause();
        }
        musicSources[currentIndex].Play();
    }

}
