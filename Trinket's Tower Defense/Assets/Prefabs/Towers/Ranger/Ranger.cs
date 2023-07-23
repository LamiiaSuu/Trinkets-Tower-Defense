using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : TowerBase
{
    private enum RangerSubclass
    {
        Hunter,
        BeastMaster,
        GloomStalker,
        HorizonWalker,
        MonsterSlayer,
        FeyWanderer,
        Swarmkeeper
    }

    [Header("Ranger Subclasses")]
    [SerializeField] RangerSubclass chosenRangerSubclass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
