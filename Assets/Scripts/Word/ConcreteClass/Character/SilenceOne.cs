using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��Ĭ��
/// </summary>
class SilenceOne : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 6;
        gender = GenderEnum.noGender;
        wordName = "�޵�";
        bookName = BookNameEnum.allBooks;
        brief = "һ��ǿ��ģ��޷��ƿ��ĵ���";
        description = "һ��ǿ��ģ��޷��ƿ��ĵ���";
        criticalSpeak = "�š���";
        deadSpeak = "�š�������";
        camp = CampEnum.enemy;
        role = gameObject.AddComponent<OldEnemy>();
        trait=gameObject.AddComponent<Pride>();
        hp=maxHP = 70;
        sp=maxSP = 20;
        atk = 15;
        def = 2;
        psy = 7;
        san = 5;
        mainSort = MainSortEnum.atk;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 3;
    }
}
