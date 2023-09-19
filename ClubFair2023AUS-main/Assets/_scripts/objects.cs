using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
   public GameObject player;
   private float timer = 0f;
   public float DeleteAfter = 8f;
   //public GameObject obstacle;

    // Update is called once per frame
    void start()
    {
        timer = Time.time;
        //obstacle = gameObject;
    }
    void Update()
    {
        if((Time.time - timer) > DeleteAfter)
        {
            //Destroy(this);
        }
    }
}
