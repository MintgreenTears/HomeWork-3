using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditHit : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip hitSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}
