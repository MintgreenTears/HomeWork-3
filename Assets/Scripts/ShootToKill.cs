using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToKill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    private int fire_rate=1;
    

    // Update is called once per frame
    void OnCollisionEnter()
    {
        Destroy(bullet);
        print("Yep");
    }
    void Update()
    {   
        
        fire_rate+=1;
      
        if (Input.GetKeyDown(KeyCode.F) && fire_rate%2==0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            
                
        }
        
    }
}
