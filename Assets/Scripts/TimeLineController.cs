using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineController : MonoBehaviour
{
    private PlayableDirector pd;
    public List<BanditTaunt> banditTaunts;
    public List<BanditShoot> banditShoots;

    private void Start()
    {
        pd = GetComponent<PlayableDirector>();
        for (int i = 0; i < banditShoots.Count; i++)
        {
            banditTaunts[i].enabled = false;
            banditShoots[i].enabled = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pd != null)
            {
                pd.Stop();
                pd.time = 58f;
                
                pd.Play();
            }
        }
        if(pd.state.ToString().Equals("Paused"))
        {
            PlayerController.canControl = true;
            Destroy(pd.gameObject);
            for(int i = 0; i < banditShoots.Count; i++)
            {
                banditTaunts[i].enabled = true;
                banditShoots[i].enabled = true;
            }
        }
    }
}
