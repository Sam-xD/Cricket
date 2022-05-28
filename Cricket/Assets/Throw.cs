using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 f = new Vector3(-11f, 6f,0f);
        rb.AddForce(f,ForceMode2D.Impulse); 
        
    }
    public void hiting()
    {
        
        
        rb.AddForce(new Vector3(22f, 0f, 0f), ForceMode2D.Impulse);

    }

    // Update is called once per frame

}
