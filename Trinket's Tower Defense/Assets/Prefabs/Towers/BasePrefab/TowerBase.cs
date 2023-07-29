using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TowerBase : EntityBase
{
    protected int [] TowerLevel = {1, 2, 3, 4, 5};

    [Header("Upgrade")]
    [SerializeField] protected GameObject upgradeMenu;
    [SerializeField] protected Button upgradeButton;

    [Header("Cost")]
    [SerializeField] protected int baseCost;

    [Header("Level")]
    [SerializeField] protected int currentTowerLevel;

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
    void Awake()
    {
        currentTowerLevel = TowerLevel[0];
        strength = baseStrength;
        dexterity = baseDexterity;
        constitution = baseConstitution;
        intelligence = baseIntelligence;
        wisdom = baseWisdom;
        charisma = baseCharisma;
        perception = CalculatePerception();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTowerLevel = TowerLevel[0];
        strength = baseStrength;
        dexterity = baseDexterity;
        constitution = baseConstitution;
        intelligence = baseIntelligence;
        wisdom = baseWisdom;
        charisma = baseCharisma;
        perception = CalculatePerception();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected int CalculatePerception()
    {
        return (wisdom + intelligence) / 2;
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
        /*
            for (int i = 1; i < TowerLevel.Length; i++)
            {
                if (currentTowerLevel == TowerLevel[i])
                {
                    currentTowerLevel = TowerLevel[i + 1];
                }
            }
        */
    }
}
