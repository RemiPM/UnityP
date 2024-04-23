using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(37.38f, 0.17f, -977f);
        }
    }
}
