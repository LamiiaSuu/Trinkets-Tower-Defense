using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{

    [Header("Tower Basics")]
    [SerializeField] private int towerCost;

    [Header("Attack Stats")]
    [SerializeField] private int attackDamage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackRange;
    [SerializeField] private int attackType;

    
    [Header("Stats")]
    [Range(8, 20)]
    [SerializeField] private int strength;
    [Range(8, 20)]
    [SerializeField] private int dexterity;
    [Range(8, 20)]
    [SerializeField] private int constitution;
    [Range(8, 20)]
    [SerializeField] private int intelligence;
    [Range(8, 20)]
    [SerializeField] private int wisdom;
    [Range(8, 20)]
    [SerializeField] private int charisma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
