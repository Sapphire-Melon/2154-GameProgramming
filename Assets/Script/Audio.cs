using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip2 walkAudioClips;
    [SerializeField] private AudioClip2 jumpAudioClips;

    // Start is called before the first frame update
    public void PlayJumpingSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioClip());
    }

    public void PlayWalkingSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioClip());
    }


    // Update is called once per frame
}
