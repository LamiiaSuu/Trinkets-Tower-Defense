using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TowerBase : EntityBase
{
    protected enum TowerLevel
    {
        Level1,
        Level2,
        Level3,
        Level4,
        Level5
    }

    [Header("Upgrade")]
    [SerializeField] protected GameObject upgradeMenu;
    [SerializeField] protected Button upgradeButton;

    [Header("Cost")]
    [SerializeField] protected int baseCost;
    [SerializeField] protected int firstUpgradeCost;

    [Header("Status")]
    [SerializeField] protected TowerLevel currentTowerLevel;

    protected int baseAttackDamage = 4;
    protected float baseAttackSpeed = 1.5f;
    protected float baseAttackRange = 3.5f;
    protected int baseStrength = 8;
    protected int baseDexterity = 8;
    protected int baseConstitution = 8;
    protected int baseIntelligence = 8;
    protected int baseWisdom = 8;
    protected int baseCharisma = 8;

    // Start is called before the first frame update
    void Start()
    {
        strength = baseStrength;
        dexterity = baseDexterity;
        constitution = baseConstitution;
        intelligence = baseIntelligence;
        wisdom = baseWisdom;
        charisma = baseCharisma;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OpenUpgradeMenu()
    {
        upgradeMenu.gameObject.SetActive(true);
    }

    protected void CloseUpgradeMenu()
    {
        upgradeMenu.gameObject.SetActive(false);
    }

    protected void Upgrade()
    {
        // if(firstUpgradeCost > LevelManager.main.curreny) return;

    }
}
