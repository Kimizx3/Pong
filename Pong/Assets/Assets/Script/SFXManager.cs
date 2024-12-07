using System;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [Header("=====Audio Source=====")] 
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource SFXSource;

    [Header("=====SXF Source=====")] 
    [SerializeField] public AudioClip background;
    [SerializeField] public AudioClip wallPong;
    [SerializeField] public AudioClip failed;
    [SerializeField] public AudioClip scored;
    [SerializeField] public AudioClip ping;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip audioClip)
    {
        SFXSource.PlayOneShot(audioClip);
    }
}
