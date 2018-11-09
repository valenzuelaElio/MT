using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager20 : MonoBehaviourSingleton<SoundManager20> {

    public AudioSource efxSource;
    public AudioSource musicSource;

    public AudioClip[] efxAudioClips;
    public AudioClip[] musicAudioClips;

    public float lowPitchRange = 0.95f;
    public float highPitchRange = 1.05f;

    public void PlayBgMusic(int index)
    {
        musicSource.clip = musicAudioClips[index];
        musicSource.Play();
    }

    public void PlaySingle(AudioClip audioClip)
    {
        efxSource.clip = audioClip;
        efxSource.Play();
    }

    public void PlaySingle(int index)
    {
        efxSource.clip = efxAudioClips[index];
        efxSource.Play();
    }


}
