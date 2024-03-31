using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public Button backButton;

    void Start()
    {
        // Load the saved volume level or set default volume
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);

        // Add listeners for UI events
        backButton.onClick.AddListener(BackToMainMenu);
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float volume)
    {
        // Set the volume and save it to PlayerPrefs
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }

    void BackToMainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
