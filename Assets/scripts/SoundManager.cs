using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    public static void PlaySound()
    {
        GameObject gameobject = new GameObject("Sound", typeof(AudioSource));
        AudioSource audioSource = gameobject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.GetInstance().duisound);
    }



}


