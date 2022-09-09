using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum eGameState
{
    Title,
    GameStart,
    Game,
    BattleStart,
    Battle,
    BattleEnd,
    GameEnd,
    GameOver
}

public class GameManger : Singleton<GameManger>
{
    // Game Events
    public delegate void GameEvent();
    public event GameEvent gameEvent;
    
    // Game States
    private eGameState gameState = eGameState.Title;
    public eGameState GameState 
    {
        get => gameState;
        set 
        { 
            gameState = value;

            switch (gameState)
            {
                case eGameState.Title:
                    break;
                case eGameState.GameStart:
                    break;
                case eGameState.Game:
                    break;
                case eGameState.BattleStart:
                    break;
                case eGameState.Battle:
                    break;
                case eGameState.BattleEnd:
                    break;
                case eGameState.GameEnd:
                    break;
                case eGameState.GameOver:
                    break;
                default:
                    break;
            }
        }
    }

    void Update()
    {
        
    }
}
