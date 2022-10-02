using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpened : MonoBehaviour
{
    public Audiomanager audiomanager; private void Start()
    {
        audiomanager = FindObjectOfType<Audiomanager>();
    }
    public void doorOpen()
    {
        audiomanager.Play("Door");
    }
}
