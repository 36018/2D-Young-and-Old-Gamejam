using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldmanProjectile : MonoBehaviour
{
    private float velocity = 30f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right*Time.deltaTime*velocity;
    }
}
