using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class StartMenu : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider VolumeSlider;
    [SerializeField] float currentVolume;
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject creditsMenu;
    [SerializeField] GameObject startMenu;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject creditsButton;
    [SerializeField] GameObject optionsButton;
    [SerializeField] GameObject quitButton;
    [SerializeField] GameObject saveButton;
    [SerializeField] GameObject backButton;

    //To-Do: How To Play?, Options Button, Menu Sound?
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        startButton.SetActive(false);
        creditsButton.SetActive(false);
        optionsButton.SetActive(false);
        quitButton.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void Options() //To-Do: Sound Slider!
    {
        startButton.SetActive(false);
        creditsButton.SetActive(false);
        optionsButton.SetActive(false);
        quitButton.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        currentVolume = volume;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("VolumePref", currentVolume);
        startButton.SetActive(true);
        creditsButton.SetActive(true);
        optionsButton.SetActive(true);
        quitButton.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void BackButton()
    {
        startButton.SetActive(true);
        creditsButton.SetActive(true);
        optionsButton.SetActive(true);
        quitButton.SetActive(true);
        creditsMenu.SetActive(false);
    }
    public void loadSettings()
    {
        if(PlayerPrefs.HasKey("VolumePref"))VolumeSlider.value = currentVolume = PlayerPrefs.GetFloat("VolumePref");
        else VolumeSlider.value = PlayerPrefs.GetFloat("VolumePref");
    }
}
