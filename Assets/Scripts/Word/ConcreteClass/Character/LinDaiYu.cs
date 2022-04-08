using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class LinDaiYu : AbstractCharacter
{
    public LinDaiYu ()
    {
        characterID = 1;
        gender = GenderEnum.girl;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        nickname = "������";
        criticalSpeak = "��л���ɻ�����";
        deadSpeak = "��������";
        maxHP  = 50;
        maxSP = 40;
        atk = 3;
        def = 0;
        psy = 20;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackSpeed = 0;
        skillSpeed = 0;
        luckyValue = 0;
    }
}
