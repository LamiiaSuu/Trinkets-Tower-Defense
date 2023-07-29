using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : MonoBehaviour
{
    private enum RogueSubclass
    {
        Thief,
        Assassin,
        ArcaneTrickster,
        Mastermind,
        Swashbuckler,
        Inquisitive,
        Scout,
        Phantom,
        Soulknife
    }

    [Header("Rogue Subclasses")]
    [SerializeField] RogueSubclass chosenRogueSubclass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
