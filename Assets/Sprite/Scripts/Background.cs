using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= new Vector3(8*Time.deltaTime,0,0);
       // if (transform.position.x < -17.7)
       // {
       //     transform.position= new Vector3(18.36f, transform.position.y);
       // }
    }
}
