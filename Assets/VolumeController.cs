using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the slider value to the current audio volume
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
        // Set the audio volume to the slider value
        audioSource.volume = volumeSlider.value;

        // Add a listener to the slider to detect changes in volume
        volumeSlider.onValueChanged.AddListener(delegate { SetVolume(volumeSlider.value); });
    }

    // Method to set the audio volume
    public void SetVolume(float volume)
    {
        // Set the audio volume to the slider value
        audioSource.volume = volume;
        // Save the volume value to PlayerPrefs for persistence
        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save(); // Save changes
    }
}
