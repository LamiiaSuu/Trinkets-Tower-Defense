using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    private enum FighterSubclass
    {
        WeaponMaster,
        Champion,
        BattleMaster,
        EldritchKnight,
        ArcaneArcher,
        Cavalier,
        Samurai,
        PsiWarrior,
        RuneKnight,
        EchoKnight,
        Brute,
        MonsterHunter,
        Scout,
        Sharpshooter
    }

    [Header("Fighter Ways")]
    [SerializeField] FighterSubclass chosenFighterWay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
