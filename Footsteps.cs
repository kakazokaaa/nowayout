using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    [SerializeField] private AudioSource footstepsAudioSource;
    [SerializeField] private AudioClip[] footstepsAudioClips;

    void FootstepsSounds ()
    {
        footstepsAudioSource.PlayOneShot(footstepsAudioClips[Random.Range(0, footstepsAudioClips.Length)]);
    }
}
