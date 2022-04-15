using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LiuGrandma : AbstractCharacter
{
    public LiuGrandma()
    {
        characterID = 3;
        gender = GenderEnum.girl;
        appearance = 3;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        nickname = "ĸ�ȳ�";
        criticalSpeak = "����";
        deadSpeak = "����Ǵ��԰��";
        maxHP = 70;
        maxSP = 10;
        atk = 7;
        def = 1;
        psy = 5;
        san = 10;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackSpeed = 2;
        skillSpeed = 0;
        luckyValue = 0;
    }
}
