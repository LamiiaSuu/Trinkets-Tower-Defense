using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBase : MonoBehaviour
{

    public enum DamageTypesList
    {
        Physical,
        MagicalPhysical,
        Fire,
        Cold,
        Lightning,
        Poison,
        Acid,
        Necrotic,
        Holy,
        Psychic,
        Force,
        none
    };

    [Header("Attack")]
    [SerializeField] protected int attackDamage;
    [SerializeField] protected float attackSpeed;
    [SerializeField] protected float attackRange;
    [SerializeField] protected DamageTypesList attackType1;
    [SerializeField] protected DamageTypesList attackType2;
    [SerializeField] protected DamageTypesList attackType3;
    
    [Header("Stats")]
    [Range(8, 20)]
    [SerializeField] protected int strength;
    [Range(8, 20)]
    [SerializeField] protected int dexterity;
    [Range(8, 20)]
    [SerializeField] protected int constitution;
    [Range(8, 20)]
    [SerializeField] protected int intelligence;
    [Range(8, 20)]
    [SerializeField] protected int wisdom;
    [Range(8, 20)]
    [SerializeField] protected int charisma;
    [SerializeField] protected int perception;

    // Start is called before the first frame update
    void Start()
    {
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
}
