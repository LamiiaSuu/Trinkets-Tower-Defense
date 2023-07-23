using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : TowerBase
{
    private enum WizardSubclass
    {
        SchoolOfAbjuration,
        SchoolOfConjuration,
        SchoolOfDivination,
        SchoolOfEnchantment,
        SchoolOfEvocation,
        SchoolOfIllusion,
        SchoolOfNecromancy,
        SchoolOfTransmutation,
        WarMagic,
        Bladesinging,
        OrderOfScribes,
        SchoolOfInvention,
        SchoolOfGraviturgy,
        SchoolOfChronurgy
    }

    [Header("Wizard Subclass")]
    [SerializeField] WizardSubclass chosenWizardCircle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
