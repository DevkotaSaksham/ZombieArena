using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplayer : MonoBehaviour
{
    public AudioSource bgmusic;
    // Start is called before the first frame update
    void Start()
    {
        bgmusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
