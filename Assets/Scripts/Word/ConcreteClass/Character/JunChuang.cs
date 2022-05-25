using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
 class JunChuang : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 8;
        gender = GenderEnum.noGender;
        wordName = "����";
        bookName = BookNameEnum.Epidemiology;
        camp = CampEnum.stranger;
        role = gameObject.AddComponent<NullRole>();
        trait = gameObject.AddComponent<NullTrait>();
        hp = maxHP = 30;
        sp=maxSP = 0;
        atk = 0;
        def = 3;
        psy = 0;
        san = 999;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 2f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 0;
        luckyValue = 0;
        mainSort = MainSortEnum.def;
    }
}
