using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DelayedSoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    // Drag and drop your AudioClip in the Inspector
    public AudioClip soundClip;

    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        // Assign the AudioClip to the AudioSource
        audioSource.clip = soundClip;

        // Invoke the PlaySound method with a delay of 2 seconds
        InvokeRepeating("PlaySound", 0.8f, 5.8f);
    }

    void PlaySound()
    {
        // Play the assigned audio clip
        audioSource.Play();
    }
}


