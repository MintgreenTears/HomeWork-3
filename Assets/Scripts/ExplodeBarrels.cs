using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBarrels : MonoBehaviour
{
    
    public GameObject ParticleSystem;
    
   
    

   
    void OnTriggerExit()
    {
        Destroy(gameObject);
        Instantiate(ParticleSystem,transform.position, transform.rotation);
          
           
        
    
       
    }
   
}