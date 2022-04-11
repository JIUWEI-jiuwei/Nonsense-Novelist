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
        wordName = "刘姥姥";
        bookName = BookNameEnum.HongLouMeng;
        nickname = "母蝗虫";
        criticalSpeak = "……";
        deadSpeak = "这就是大观园吗？";
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
