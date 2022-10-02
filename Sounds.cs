using System.Collections; using UnityEngine.Audio;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sounds 
{
    [HideInInspector]
    public AudioSource source;
    public AudioClip clip;
    [Range (0f, 1f)]
    public float volume;
    public string name;
    public bool loop;
}
