using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 经济压力
/// </summary>
class FinancialDifficulty : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 7;
        gender = GenderEnum.noGender;
        wordName = "经济压力";
        bookName = BookNameEnum.allBooks;
        camp = CampEnum.enemy;
        role = gameObject.AddComponent<Bank>();
        trait=gameObject.AddComponent<NullTrait>();
        hp=maxHP = 40;
        sp=maxSP = 10;
        atk = 10;
        def = 12;
        psy = 0;
        san = 2;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 7;
        luckyValue = 0;
        enemyLevel = 2;
    }
}
