using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public float loopSpeed;
    public Renderer backGroundRenderer;
    void Update()
    {
        backGroundRenderer.material.mainTextureOffset += new Vector2(loopSpeed* Time.deltaTime, 0f);
    }
    public void EndLoop()
    {
        loopSpeed = 0f;
    }
}
