using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpOne : MonoBehaviour
{
    [Range(1, 5)]
    public float jV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jV;

        }
        
    }
}
