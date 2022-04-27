using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FinancialDifficulty : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 7;
        gender = GenderEnum.noGender;
        wordName = "宿敌";
        bookName = BookNameEnum.allBooks;
        deadSpeak = "输给你？怎么可能！";
        camp = CampEnum.enemy;
        role = gameObject.AddComponent<Bank>();
        trait=gameObject.AddComponent<NullTrait>();
        hp=maxHP = 40;
        sp=maxSP = 10;
        atk = 10;
        def = 12;
        psy = 0;
        san = 0;
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
