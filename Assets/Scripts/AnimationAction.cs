using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    private AudioSource m_AudioSource;
    public List<AudioClip> audioClips;

    private void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    public void PlaySFX(int i)
    {
        m_AudioSource.PlayOneShot(audioClips[i]);
    }
}
