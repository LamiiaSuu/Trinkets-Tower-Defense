using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DamageTypes;
using static Stats;
using static TowerBase;

public class Druid : TowerBase 
{
    // Start is called before the first frame update
    void Start()
    {
        IncreasePerception();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IncreasePerception()
    {
        int perception = Stats.GetPerception();
        Stats.SetPerception((perception / 100) * 15);
    }
}
