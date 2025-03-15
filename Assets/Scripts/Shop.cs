using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    
    public void PurchaseScout()
    {
        BuildManager.instance.SetTowerToBuild(BuildManager.instance.Scout);
    }

    public void PurchaseSoldier()
    {
        BuildManager.instance.SetTowerToBuild(BuildManager.instance.Soldier);
    }
    public void PurchaseSniper()
    {
        BuildManager.instance.SetTowerToBuild(BuildManager.instance.Sniper);
    }
}
