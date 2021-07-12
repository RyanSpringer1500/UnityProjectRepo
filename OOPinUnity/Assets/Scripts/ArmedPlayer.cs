/** (Ryan Springer) * 
 * (Assignment6) * 
 * (player's weapon) */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedPlayer : MonoBehaviour
{
    public int damageBonus;

    public Player enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Player>();
        
    }
}
