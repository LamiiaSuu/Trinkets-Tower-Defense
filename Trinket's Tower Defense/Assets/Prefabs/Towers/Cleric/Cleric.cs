using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleric : MonoBehaviour
{
    private enum ClericSubclass
    {
        DomainOfKnowledge,
        DomainOfLife,
        DomainOfLight,
        DomainOfNature,
        DomainOfTempest,
        DomainOfTrickery,
        DomainOfWar,
        ArcanaDomain,
        DeathDomain,
        ForgeDomain,
        GraveDomain,
        OrderDomain,
        ProtectionDomain,
        SolidarityDomain,
        TwilightDomain
    }

    [Header("Cleric Subclass")]
    [SerializeField] ClericSubclass chosenClericDomain;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
