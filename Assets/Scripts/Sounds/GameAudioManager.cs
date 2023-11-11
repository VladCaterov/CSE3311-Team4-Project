using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameAudioManager : MonoBehaviour
{
    public static GameAudioManager instance;
    public Sound[] sounds;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        Play("Main Audio");
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.soundName == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}
