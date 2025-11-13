using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static Action gameOver;
    [SerializeField] private int hp = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            gameOver?.Invoke();
        }
    }
}
