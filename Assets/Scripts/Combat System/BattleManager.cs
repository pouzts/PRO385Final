using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public enum eBattleState
{
    BattleStart,
    SelectAction,
    TurnStart,
    PlayerTurn,
    EnemyTurn,
    EndStart,
    Flee,
    Lose,
    Win,
    BattleEnd
}

public enum ePlayerChoice
{ 
    Attack,
    Heal,
    Flee
}

public class BattleManager : MonoBehaviour
{
    public GameObject enemy;

    public Transform enemySpawn;

    // Battle States
    private eBattleState battleState;

    // Player Choices
    private ePlayerChoice playerChoice;

    private void Start()
    {
        battleState = eBattleState.BattleStart;
    }

    private void Update()
    {
        //print(battleState);

        switch (battleState)
        {
            case eBattleState.BattleStart:
                StartCoroutine("BattleStart");
                break;
            case eBattleState.SelectAction:
                break;
            case eBattleState.TurnStart:
                break;
            case eBattleState.PlayerTurn:
                break;
            case eBattleState.EnemyTurn:
                break;
            case eBattleState.BattleEnd:
                break;
            case eBattleState.Flee:
                break;
            case eBattleState.Lose:
                break;
            case eBattleState.Win:
                break;
        }
    }

    private IEnumerable BattleStart()
    {
        Instantiate(enemy, enemySpawn);
        yield return new WaitForSeconds(2f);
        battleState = eBattleState.SelectAction;
    }

    private void PlayerTurn()
    {
    
    }

    private void EnemyTurn()
    {

    }

    private void BattleEnd()
    {
        
    }

    private void Lose()
    { 

    }

    private void Flee()
    { 
    
    }

    private void Win()
    { 
    
    }

    //private void 
}
