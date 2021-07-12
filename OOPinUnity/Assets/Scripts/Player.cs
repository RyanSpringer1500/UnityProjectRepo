using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour, PlayerIDamage 
{
    protected float speed;
    protected int health;

    [SerializeField] protected ArmedPlayer weapon;

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<ArmedPlayer>();
        speed = 5f;
        health = 100;

        weapon.damageBonus = 10;
    }
    protected abstract void Attack(int amount);
    public abstract void TakeDamage(int amount);


}
