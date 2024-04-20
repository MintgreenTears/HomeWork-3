using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineController : MonoBehaviour
{
    private PlayableDirector pd;

    private void Start()
    {
        pd = GetComponent<PlayableDirector>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pd != null)
            {
                pd.Stop();
                pd.time = 57.27f;
                PlayerController.canControl = true;
                pd.Play();
            }
        }
    }
}
