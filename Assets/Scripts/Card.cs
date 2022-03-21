using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    [SerializeField] string cardName;
    [SerializeField] bool cultMember;

    //maybe replace with game objects tag
    [SerializeField] string team;
    //maybe remove and find a different way to flag winners
    [SerializeField] bool winningTeam;
    //maybe remove and just add a vampire script to the object if it becomes one
    [SerializeField] bool isVampire;


    public abstract void OnGameStart();
    public abstract void OnMorningEvent();
    public abstract void OnNightEvent();
    public abstract void OnTrialEvent();
    public abstract void OnDeadEvent();
    public abstract bool CheckWinCondition();
}
