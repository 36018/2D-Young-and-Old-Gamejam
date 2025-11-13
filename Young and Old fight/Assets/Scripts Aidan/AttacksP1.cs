using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacksP1 : MonoBehaviour
{
    public Dictionary<string, GameObject> attackList = new Dictionary<string, GameObject>();
    private Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!movement)//.inAir)
            {

            }
            else
            {

            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {

        }
        if (Input.GetKeyDown(KeyCode.C))
        {

        }
    }
}
