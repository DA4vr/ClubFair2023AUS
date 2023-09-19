using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cought : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag == "Player")
        {
            Debug.Log("triggered");
            Destroy(player);
        }
    } 
}
