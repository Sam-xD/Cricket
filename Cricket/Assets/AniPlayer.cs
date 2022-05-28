using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniPlayer : MonoBehaviour
{
    Throw ball;
    
    // Start is called before the first frame update
    void Update()
    {
        Animator anim;
        anim = GetComponent<Animator>();
        anim.SetBool("shot", false);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            anim.SetBool("shot",true);

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.Space) && collision.name=="ball")
        {
            /*f=new Vector3(0f, -8f, 0f)
            collision.GetComponent<Rigidbody2D>().velocity=f;*/
            ball = FindObjectOfType<Throw>();
            ball.hiting();
            

        }

    }

    // Update is called once per frame
    
    
}
