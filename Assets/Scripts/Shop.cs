using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    Player player;
    public void PurchaseScout()
    {
        if (player.coins >= 75)
        {
            BuildManager.instance.SetTowerToBuild(BuildManager.instance.Scout);
            player.coins =- 75;
        }
    }

    public void PurchaseSoldier()
    {
        if (player.coins >= 125)
        {
            BuildManager.instance.SetTowerToBuild(BuildManager.instance.Soldier);
            player.coins = -125;
        }
    }
    public void PurchaseSniper()
    {
        if (player.coins >= 150)
        {
            BuildManager.instance.SetTowerToBuild(BuildManager.instance.Sniper);
            player.coins = -150;
        }
    }
}
