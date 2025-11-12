using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldmanProjectile : MonoBehaviour
{
    public float velocity = 30f;
    private float timePassed = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right*Time.deltaTime*velocity;

        timePassed += Time.deltaTime;

        if (timePassed > 3f)
        { 
            Destroy(gameObject);
        }
    }
}
