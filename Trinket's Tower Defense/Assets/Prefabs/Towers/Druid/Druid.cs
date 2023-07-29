using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Druid : MonoBehaviour
{
    private enum DruidSubclass
    {
        none,
        CircleOfTheLand,
        CircleOfTheMoon,
        CircleOfDreams,
        CircleOfTheShepherd,
        CircleOfSpores,
        CircleOfStars,
        CircleOfWildfire
    }

    [Header("Druid Circle")]
    [SerializeField] DruidSubclass chosenDruidCircle = DruidSubclass.none;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BeastShape()
    {
    //    if (currentTowerLevel >= 2)
    //    {
    //    }
    //    else 
    //    {
    //        return;
    //    }
    }

    void chooseDruidCircle()
    {
      //  if (currentTowerLevel >= 2)
      //  {
      //    } 
       //    else 
    //    {
    //        return;
    //    }
    }
}
