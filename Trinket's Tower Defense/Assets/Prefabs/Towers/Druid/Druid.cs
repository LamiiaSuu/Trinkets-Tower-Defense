using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Druid : TowerBase
{
    private enum DruidSubclass
    {
        CircleOfTheLand,
        CircleOfTheMoon,
        CircleOfDreams,
        CircleOfTheShepherd,
        CircleOfSpores,
        CircleOfStars,
        CircleOfWildfire
    }

    [Header("Druid Circle")]
    [SerializeField] DruidSubclass chosenDruidCircle;

    // Start is called before the first frame update
    void Start()
    {
        perception += EnhancedPerception();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int EnhancedPerception()
    {
        return ((perception / 100) * 15);
    }

    void BeastShape()
    {

    }

}
