using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LFSample : MonoBehaviour
{
    private Renderer mouseColor;
    public AudioSource audioSource;
    
    private void Awake()
    {
        mouseColor = GetComponent<Renderer>();
        mouseColor.material.color = Color.white;
    }

    private void OnMouseEnter()
    {
        mouseColor.material.color = Color.blue;
    }

    private void OnMouseDown()
    {
        mouseColor.material.color = Color.green;
        
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = true;
        audioSource.Play();
        
        Debug.Log("Audio is Playing");
        
        return;

    }
}
