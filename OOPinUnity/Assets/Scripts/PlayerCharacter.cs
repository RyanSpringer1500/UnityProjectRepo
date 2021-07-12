/** (Ryan Springer) * 
 * (Assignment6) * 
 * (player stats) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Player
{
    protected int damage;
   
    protected override void Awake()
    {
        base.Awake();
        health = 25;
        GameManager.Instance.score += 4;
        speed = 7f;
    }
    protected override void Attack(int amount)
    {
        Debug.Log("Player attacks!");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took" + amount + "points of damage");
    }
}
