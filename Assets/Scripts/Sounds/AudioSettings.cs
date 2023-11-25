using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public Toggle audioToggle;
    public Slider volumeSlider;
    public Button backButton;
    
    void Start()
    {
        GameObject audioManager = GameObject.FindGameObjectWithTag("AudioManager");
        AudioSource[] audioSources = audioManager.GetComponents<AudioSource>();


        backButton.onClick.AddListener(delegate{ GoBack(); });

        audioToggle.onValueChanged.AddListener(delegate
        {
           
            if (!audioToggle.isOn)
            { 
                foreach (AudioSource audioSource in audioSources)
                {
                    audioSource.volume = 0f;
                }
            }
            else
            {
                foreach (AudioSource audioSource in audioSources)
                {
                    audioSource.volume = volumeSlider.value;
                }
            }
            
        });

        volumeSlider.value = audioSources[0].volume;
        volumeSlider.onValueChanged.AddListener(delegate
        {
            audioSources[0].volume = volumeSlider.value;

	    });
    }
    void GoBack()
    {
        SceneManager.LoadScene("Start");
    }
}
