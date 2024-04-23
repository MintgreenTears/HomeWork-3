using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelExplosion : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip explosionSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            audioSource.PlayOneShot(explosionSound);
        }
    }
}
