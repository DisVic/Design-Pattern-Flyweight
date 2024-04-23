using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSpawner : MonoBehaviour
{
    [SerializeField] private PersonStats stats;
    [SerializeField] private Person person;

    private void Start()
    {
        for (int x = 0; x < 1000; x++)
        {
            for (int y = 0; y < 1000; y++)
            {
                Spawn(new Vector2(x, y) + (Vector2)transform.position);
            }
        }
    }
    private void Spawn(Vector2 position)
    {
        Person pers = Instantiate(person);

        pers.Init(stats, position);//FLyweight

        //pers.Init(person.health = 10, person.damage = 10, person.moveSpeed = 10, person.cooldown = 10, position);
    }
}
