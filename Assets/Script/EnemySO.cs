using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Item", order = 1)]

public class EnemySO : ScriptableObject
{
    
    public float speed;
    public float Health;
    public float Damage;
}
