using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleCommon
{

    public static int CallDamage(Unit attacker, Unit defender, AttackType type)
    {
        int str = 0;
        int def = 0;
        float rnd;

        if (type == AttackType.physics)
        {
            str = attacker.str;
            def = defender.def;
        }

        rnd = Random.Range(40, 120);

        int damage = (int)Mathf.Floor((str * 1.5 + rnd) - def);
        return damage;

    }
    public enum AttackType
    {
        physics
    }
}
