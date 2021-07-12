/** (Ryan Springer) * 
 * (Assignment6) * 
 * (manages enemey weapons) */

using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }
    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
        
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }

    
}
