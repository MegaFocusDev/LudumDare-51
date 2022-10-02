using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public PlayerMovement pm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            pm.gravityChange();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
