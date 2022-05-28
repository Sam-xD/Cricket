using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stumped : MonoBehaviour
{
     Animator an;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ball")
        {
            an = GetComponent<Animator>();
            an.SetBool("hit", true);
            Invoke("reload",2f);
        }
        
        
    }
    void reload()
    {
        SceneManager.LoadScene(0);
    }

}
