using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float t;
    // Start is called before the first frame update
  
    public Text points;
    void Start()
    {
        t = 0f;

    }

    // Update is called once per frame
    void Update()
    {
       
        points.text ="Score:"+(int)t;
        t = t + 1 * Time.deltaTime;
    }
}
