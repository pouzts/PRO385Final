using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Stats
{
    public int attack;
    public int defense;
    public int speed;
    public int luck;

    public Stats(int attack, int defense, int speed, int luck)
    { 
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.luck = luck;
    }

    public static Stats operator +(Stats stats)
    { 
        return stats;
    }

    public static Stats operator -(Stats stats)
    {
        return new Stats(-stats.attack, -stats.defense, -stats.speed, -stats.luck);
    }

    public static Stats operator +(Stats stats1, Stats stats2)
    {
        return new Stats(stats1.attack + stats2.attack,
                stats1.defense + stats2.defense,
                stats1.speed + stats2.speed,
                stats1.luck + stats2.luck);
    }

    public static Stats operator -(Stats stats1, Stats stats2)
    {
        return stats1 + (-stats2);
    }

    public static Stats operator *(Stats stats1, Stats stats2)
    {
        return new Stats(stats1.attack * stats2.attack,
                stats1.defense * stats2.defense,
                stats1.speed * stats2.speed,
                stats1.luck * stats2.luck);
    }

    public static Stats operator /(Stats stats1, Stats stats2)
    {
        if (stats2.attack == 0 || stats2.defense == 0 || stats2.speed == 0 || stats2.luck == 0)
            throw new DivideByZeroException();

        return new Stats(stats1.attack / stats2.attack,
                stats1.defense / stats2.defense,
                stats1.speed / stats2.speed,
                stats1.luck / stats2.luck);
    }
}
