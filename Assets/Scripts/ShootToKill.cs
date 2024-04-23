using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToKill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    private int fire_rate=1;
    private AudioSource audioSource;
    public AudioClip shootSound;


    // Update is called once per frame
    //void OnCollisionEnter()
    //{
    //    Destroy(bullet);
    //    print("Yep");
    //}

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
    void Update()
    {   
        
        fire_rate+=1;
      
        if (Input.GetKeyDown(KeyCode.F) && fire_rate%2==0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            audioSource.PlayOneShot(shootSound,0.4f);


        }
        
    }
}
