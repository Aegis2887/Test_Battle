using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameController : MonoBehaviour
{
    public void ButtonClick(int type)
    {
        Battle((AttackType)type);
    }

    public void Battle(AttackType type)
    {

        BattleManager.Instance.myUnit.attackTarget = BattleManager.Instance.enemyUnit;
        BattleManager.Instance.enemyUnit.attackTarget = BattleManager.Instance.myUnit;

        List<Unit> order = new List<Unit>();

        int rnd = Random.Range(0, 1);
        if (rnd == 0)
        {
            order.Add(BattleManager.Instance.myUnit);
            order.Add(BattleManager.Instance.enemyUnit);
        }
        else
        {
            order.Add(BattleManager.Instance.enemyUnit);
            order.Add(BattleManager.Instance.myUnit);
        }

        foreach (var unit in order)
        {
            unit.Attack(unit, unit.AttackTarget, type);
            if (unit.attackTarget.hp <= 0)
            {

            }
        }
    }
}