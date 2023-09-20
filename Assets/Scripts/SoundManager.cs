using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip []clip1;

    private AudioSource audio;

    public void  Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlaySoundPotion()
    {
        audio.clip = clip1[0];

        audio.Play();
    }

    public void PlaySoundOpenDoor()
    {
        audio.clip = clip1[1];

        audio.Play();
    }

    public void PlaySoundWin()
    {
        audio.clip = clip1[2];

        audio.Play();
    }

    public void PlaySoundLose()
    {
        audio.clip = clip1[3];

        audio.Play();
    }

    public void PlaySoundHurt()
    {
        audio.clip = clip1[4];

        audio.Play();
    }
    public void PlayMusicGame()
    {
        audio.clip = clip1[5];

        audio.Play();
    }
    public void PlayPickKey()
    {
        audio.clip = clip1[6];

        audio.Play();
    }

    public void PlaySoundTeleport()
    {
        audio.clip = clip1[7];

        audio.Play();
    }

}
