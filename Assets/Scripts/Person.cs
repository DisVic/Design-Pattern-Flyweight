using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Person : MonoBehaviour
{
    private PersonStats stats;//Flyweight

    //public float health;
    //public float damage;
    //public float moveSpeed;
    //public float cooldown;

    public Vector2 position;

    public void Init(PersonStats _stats, Vector2 _position)//Flyweight
    {
        stats = _stats;
        position = _position;
        transform.position = _position;
    }

    //public void Init(float _health, float _damage, float _moveSpeed, float _cooldown, Vector2 _position)
    //{
    //    health = _health;
    //    damage = _damage;
    //    moveSpeed = _moveSpeed;
    //    cooldown = _cooldown;
    //    position = _position;
    //    transform.position = _position;
    //}

}
