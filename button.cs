using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Animator animator;
    private bool isPressed;
    public door Door;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && !isPressed)
        {
            isPressed = true;
            Door.neededCount--;
            animator.SetBool("isPressed_", true);
        }
    }
    void Update()
    {
        
    }
}
