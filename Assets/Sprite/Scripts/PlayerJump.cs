using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb ;
    public float jump;
    public float jumpV;
    bool oneJump = true;
    bool canMove = true;

    [SerializeField] float baseSpeed = 10f;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            oneJump = true;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            rb.AddForce(new Vector2(jumpV,0));
            
        }
        if (other.tag == "DoubleJump")
        {
            oneJump = true;
        }
    }
    
    void Update()
    {
        if (canMove == true){
            Moving();
        }
        if (Input.GetKeyDown(KeyCode.Space) && oneJump == true)
        {
            rb.AddForce(new Vector2(0, jump));
            oneJump = false;
        }
    }
    void Moving()
    {
        surfaceEffector2D.speed = baseSpeed;
    }
    public void DisableControls ()
    {
        canMove = false;
        surfaceEffector2D.speed = 0;
    }
}
