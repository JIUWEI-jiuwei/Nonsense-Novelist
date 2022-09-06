using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 宿敌（暂时弃用）
/// </summary>
class AgelessEnemy_x : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = -1;
        gender = GenderEnum.noGender;
        wordName = "宿敌";
        bookName = BookNameEnum.allBooks;
        description = "长期与你过不去，并且不知为何总是会不断遇到对方";
        criticalSpeak = "你比我弱太多了";
        deadSpeak = "输给你？怎么可能！";     
        role = gameObject.AddComponent<OldEnemy>();
        trait = gameObject.AddComponent<Pride>();
        hp=maxHP = 70;
        sp=maxSP = 20;
        atk = 15;
        def = 2;
        psy = 7;
        san = 2;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 3;
    }

    public override string ShowText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string LowHPText()
    {
        return "";
    }
    public override string DieText()
    {
        return "";
    }
}
