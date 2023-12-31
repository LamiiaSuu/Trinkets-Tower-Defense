using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : EntityBase
{   
    [Header("Stats")]
    [SerializeField] private int health;

    [Header("Defense")]
    [SerializeField] private int defense;

    [Header("Resistance")]
    [SerializeField] private DamageTypesList resistanceType1;
    [SerializeField] private DamageTypesList resistanceType2;
    [SerializeField] private DamageTypesList resistanceType3;

    [Header("Immunity")]
    [SerializeField] private DamageTypesList immunityType1;
    [SerializeField] private DamageTypesList immunityType2;
    [SerializeField] private DamageTypesList immunityType3;

    [Header("Vulnerability")]
    [SerializeField] private DamageTypesList vulnerabilityType1;
    [SerializeField] private DamageTypesList vulnerabilityType2;
    [SerializeField] private DamageTypesList vulnerabilityType3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
