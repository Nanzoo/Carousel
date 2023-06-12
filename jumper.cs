using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jumper : MonoBehaviour
{
    public float fM = 2.5f;
    public float lMF = 1.5f;

    public float y1 = 20;
    public float y2 = -20;

    public Text text;
    int x = 0;

    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {

       // Vector3 objectScale = transform.localScale;

        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x==0)
            text.enabled = false;
        fM += .00085f;
        lMF += .00085f;
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            gameObject.transform.localScale -= new Vector3(0f, 2.4f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            gameObject.transform.localScale += new Vector3(0f, 2.4f, 0f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector3.up * 1;
        }
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fM - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lMF - 1) * Time.deltaTime;
        }

        

        if (transform.position.y > 16f)
        {
            transform.position = new Vector3(transform.position.x, 2.33f, transform.position.z);
        }
        if (transform.position.y < y2)
        {
            transform.position = new Vector3(transform.position.x, y2, transform.position.z);
            //SceneManager.LoadScene("WinnerOne");
            text.enabled = true;
            x++;


        }
        

        //
    //transform.position = new Vector3(transform.position.x, -10, transform.position.z);
    /*
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    */
    }
}
