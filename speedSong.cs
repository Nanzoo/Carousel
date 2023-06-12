using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedSong : MonoBehaviour
{
    AudioSource aS;
    public Text text;
    public Text text1;
    void Start()
    {
        aS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //if (text.enabled == false && text1.enabled == false)
            aS.pitch += .015f * (Time.deltaTime/5);
        Debug.Log(aS.pitch);


    }
}
