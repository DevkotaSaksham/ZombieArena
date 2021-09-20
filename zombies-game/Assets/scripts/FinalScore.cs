using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
  //  public float t;
    // Start is called before the first frame update
    //public Text highscore;
    public Text scorel;
  
    public void Final(float s)
    {
        Debug.Log(s);
       // PlayerPrefs.SetInt("HighScore", s);
        scorel.text = "Final Score:" + (int)s;
    }
}
