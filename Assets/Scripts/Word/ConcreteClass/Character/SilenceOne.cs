using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 沉默者
/// </summary>
class SilenceOne : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 6;
        gender = GenderEnum.noGender;
        wordName = "沉默者";
        bookName = BookNameEnum.allBooks;
        brief = "一个强大的，无法绕开的敌人";
        description = "一个强大的，无法绕开的敌人";
        criticalSpeak = "嗯……";
        deadSpeak = "嗯……？！";
        camp = CampEnum.enemy;
        role = gameObject.AddComponent<OldEnemy>();
        trait=gameObject.AddComponent<Pride>();
        hp=maxHP = 200;
        sp=maxSP = 20;
        atk = 15;
        def = 2;
        psy = 7;
        san = 30;
        mainSort = MainSortEnum.atk;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 3;
        bg_text = "一个强大的，无法绕开的敌人";
        mainSort = MainSortEnum.atk;
    }
}
