using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviourSingleton<SoundManager> {

    //public string[] audioNames;
    public AudioClip[] audioClips;
    public AudioClip[] audioEffects;
    private bool clipFound;

    public GameObject audioEffectsGO;
    private AudioSource audioSourceEffects;
    private AudioSource localAudioSource;

    void Start () {
        audioSourceEffects = audioEffectsGO.GetComponent<AudioSource>();
        localAudioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(int index)
    {
        localAudioSource.Stop();
        localAudioSource.clip = audioClips[index];
        localAudioSource.Play();
    }
	
    public void LocalAudioStop()
    {
        localAudioSource.enabled = false;
        localAudioSource.Stop();
    }

    /*
    public void Play (string clipName)
    {
        for (int i = 0; i < audioNames.Length; i++)
        {
            if(clipName == audioNames[i])
            {
                localAudioSource.clip = audioClips[i];
                localAudioSource.enabled = true;
                localAudioSource.Play();
                clipFound = true;
                break;
            } else
            {
                clipFound = false;
            }
            
        }

        if (!clipFound)
        {
            Debug.Log("Audio Clip not Found");
        }
    }
    */

    public void playEffect(int index)
    {
        if(audioSourceEffects == null)
        {
            audioSourceEffects = audioEffectsGO.GetComponent<AudioSource>();
        }
        audioSourceEffects.Stop();
        audioSourceEffects.clip = audioEffects[index];
        audioSourceEffects.enabled = true;
        audioSourceEffects.Play();

    }
}
