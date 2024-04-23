using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStraight : MonoBehaviour
{
    // Start is called before the first frame update
    private float fire_rate=30;
    

    // Update is called once per frame
    void Update()
    {
       transform.Translate(0,0,fire_rate*Time.deltaTime);
    }
}
