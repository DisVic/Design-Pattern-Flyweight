using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PersonStatsScriptableObject", menuName = "ScriptableObjects/person")]
public class PersonStats : ScriptableObject
{
    public float health;
    public float damage;
    public float moveSpeed;
    public float cooldown;
}
