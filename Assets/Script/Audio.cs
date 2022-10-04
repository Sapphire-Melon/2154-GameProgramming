using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip2 walkAudioClips;
    [SerializeField] private AudioClip2 jumpAudioClips;
    [SerializeField] private AudioClip2 collectAudioClips;
    [SerializeField] private AudioClip2 dedAudioClips;

    // Start is called before the first frame update
    public void PlayJumpingSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioClip());
    }

    public void PlayWalkingSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioClip());
    }

    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectAudioClips.GetAudioClip());
    }
    public void PlayDedSound()
    {
        audioSource.PlayOneShot(collectAudioClips.GetAudioClip());
    }



    // Update is called once per frame
}
