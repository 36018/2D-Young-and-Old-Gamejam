using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackStats : MonoBehaviour //would've liked to use getters and setters but the scope is so small that i don't really care
{
    public int damage;
    public float knockbackScale; // don't make this higher than like 2 or something!!!
    public float startupFrames;
    public float activeFrames;
    public float endlag;
}
