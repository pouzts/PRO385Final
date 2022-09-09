using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>, IBattleable
{
    public string playerName;
    public int maxHP;

    public int level;
    public int exp;

    public Stats stats;

    public int HP { get; set; }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Attack()
    {
        int critNum = (int)Random.Range(0, stats.luck);
    }

    public void Heal()
    {
    }

    public bool IsDead()
    {
        return HP <= 0;
    }
}
