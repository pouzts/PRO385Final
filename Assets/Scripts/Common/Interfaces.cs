using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDestructable
{
    void OnDestroy();
}

public interface IBattleable
{
    void Attack();
    void Heal();
    bool IsDead();
}