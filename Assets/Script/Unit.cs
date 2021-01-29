using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BattleCommon;



public class Unit : MonoBehaviour
{   //ステータス
    public int hp;

    public int str;

    public int def;

    public int spd;

    //攻撃対象
    public Unit Target;

    public void Attack(Unit attacker, Unit defender, AttackType type)
    {
        int damage = BattleCommon.CallDamage(attacker, defender, type);
        defender.hp -= damage;
    }
}