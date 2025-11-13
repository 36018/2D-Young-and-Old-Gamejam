using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    private AttackStats thisAttackStats;
    private bool takingKnockback = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = -1 * thisAttackStats.knockbackScale;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent != this.gameObject)
        {
            takingKnockback = true;
            thisAttackStats = collision.gameObject.GetComponent<AttackStats>();
        }
    }
}
