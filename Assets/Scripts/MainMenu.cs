using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public void Testing()
    {
        SceneManager.LoadScene("Testing");
    }
    public void QuitGame()
    {
        Debug.Log("Quit"); 
        Application.Quit();
    }
    public void OptionMenu()
    {
        SceneManager.LoadScene("OptionScene");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SetVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }
    public AudioMixer audioMixer;

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
