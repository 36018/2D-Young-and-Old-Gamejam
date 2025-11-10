using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMan : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float jumppower = 1f;
    [SerializeField] private GameObject Projectileprefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject bullet = Instantiate(Projectileprefab);
            bullet.transform.position = transform.position;
        }
    }
}
