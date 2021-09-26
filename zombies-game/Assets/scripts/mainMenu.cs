using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // public static bool VolumeToggle = true;

    // public static AudioSource bgMusic;

    // public void StartMusic()
    // {
    //     bgMusic.Play();
    // }

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    // public void CheckToggle()
    // {
    //     if(VolumeToggle == false)
    //     {
    //         bgMusic.pitch -= 1f;
    //     }

    //     if(VolumeToggle == true) 
    //     {
    //         bgMusic.pitch += 1f;
    //     }
        
    // }
}
