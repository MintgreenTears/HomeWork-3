using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banditsdeath : MonoBehaviour
{
    // Start is called before the first frame update
   
   

    // Update is called once per frame
    void Awake()
    {
        
    }
    void OnTriggerExit()
    {
       GetComponent<Animator>().Play("death2");
       
    }
}
