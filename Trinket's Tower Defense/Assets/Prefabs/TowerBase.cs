using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Stats;
using static DamageTypes;

public class TowerBase : MonoBehaviour
{
    enum TowerLevel
    {
        Level1,
        Level2,
        Level3,
        Level4,
        Level5
    }

    [Header("Cost")]
    [SerializeField] private int baseCost;
    [SerializeField] private int firstUpgradeCost;

    [Header("Status")]
    [SerializeField] private TowerLevel currentTowerLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
