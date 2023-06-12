using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spinner : MonoBehaviour
{
    float timer;
    public Text text;
    public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<60)
        {
            timer += Time.deltaTime;
        }
        //if (text.enabled == false && text1.enabled == false)
            transform.Rotate(0f, .003f * timer, 0f);
        //else
            transform.Rotate(0f, 0f, 0f);
    }
}
