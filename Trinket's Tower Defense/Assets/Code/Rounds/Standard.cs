using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standard : MonoBehaviour
{
    [Header("Rounds")]
    [SerializeField] static public GameObject[] RoundOne;

    [Header("Enemies")]
    [SerializeField] public GameObject Triangle;



    public static GameObject[] getRoundEnemies(int roundNumber){
        switch (roundNumber)
        {

            case 1:
            default:
                return RoundOne;
                break;
        }
}

}