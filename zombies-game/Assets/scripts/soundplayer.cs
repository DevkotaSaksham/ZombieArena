using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplayer : MonoBehaviour
{
    public AudioSource bgmusic;
    // public static bool musicToggle = true;
    // Start is called before the first frame update
    void Start()
    {
        bgmusic.Play();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(!musicToggle){
    //         bgmusic.Pause();
    //     }else{
    //         bgmusic.Play();
    //     }
        
    // }

    // public void isPressed ()
    // {
    //     if(musicToggle){
    //         musicToggle = false;
    //     }else{
    //         musicToggle = true;
    //     }
    // }
}
