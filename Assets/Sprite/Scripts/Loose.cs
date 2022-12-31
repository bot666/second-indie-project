using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loose : MonoBehaviour
{
    // Start is called before the first frame update
    public float reloadTime;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Lava")
        {
            Invoke("reloadScene", reloadTime);
            FindObjectOfType<PlayerJump>().DisableControls();
            FindObjectOfType<Loop>().EndLoop();
        }
    }
    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
