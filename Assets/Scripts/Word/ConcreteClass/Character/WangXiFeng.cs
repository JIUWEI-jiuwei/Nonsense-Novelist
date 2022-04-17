using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WangXiFeng : AbstractCharacter
{
    public WangXiFeng()
    {
        characterID = 4;
        gender = GenderEnum.girl;
        appearance = 4;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        nickname = null;
        criticalSpeak = "��������������ǽ������";
        deadSpeak = "���һ����㾡����";
        maxHP = 50;
        maxSP = 15;
        atk = 10;
        def = 1;
        psy = 10;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackSpeed = 1.3f;
        skillSpeed = 0;
        luckyValue = 0;
    }
}
