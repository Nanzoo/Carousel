using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hitter")
        {
            Debug.Log("hit");
            transform.position = new Vector3(transform.position.x -.75f, transform.position.y, transform.position.z + .75f);
        }
    }
}
