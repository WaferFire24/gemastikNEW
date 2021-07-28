using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffect : MonoBehaviour
{
    public AudioSource touch;
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        touch.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
