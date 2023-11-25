using UnityEngine.Audio;
using System;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] sounds;
    private float setVolume;
    // Start is called before the first frame update
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            setVolume = s.source.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
        
    void Start()
    {
        Play("main");
    }
    //void Update()
    //{
            
    //    if (gameObject.tag == "Mute-AudioManager")
    //    {
    //        foreach (Sound s in sounds)
    //        {
    //            s.source.volume = 0f;
    //        }
    //    }
    //    else
    //    {
    //        foreach (Sound s in sounds)
    //        {
    //            s.source.volume = setVolume;
    //        }
    //    }
    //}
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}


