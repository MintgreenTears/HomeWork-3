using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip hitSound;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Destroy(this.gameObject,5f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            // Player is hit
            audioSource.PlayOneShot(hitSound);
        }
        Destroy(this.gameObject,2f);
    }


}
