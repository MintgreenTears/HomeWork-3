using System.Collections;
using UnityEngine;

public class BanditTaunt : MonoBehaviour
{
    public AudioClip[] taunts;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayTaunts());

    }

    IEnumerator PlayTaunts()
    {
        //Loop through the while loop
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10, 30));
            int randomIndex = Random.Range(0, taunts.Length);
            audioSource.PlayOneShot(taunts[randomIndex]);

        }
    }
}