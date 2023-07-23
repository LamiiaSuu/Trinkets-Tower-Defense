using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamageTypes;

public class TowerBase : MonoBehaviour
{

    [Header("Attack")]
    [SerializeField] private int attackDamage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackRange;
    [SerializeField] private DamageTypesList attackType1;
    [SerializeField] private DamageTypesList attackType2;
    [SerializeField] private DamageTypesList attackType3;
    
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
