using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LiuGrandma : AbstractCharacter
{
    public LiuGrandma()
    {
        characterID = 3;
        gender = GenderEnum.girl;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add( "ĸ�ȳ�");
        deadSpeak = "����Ǵ��԰��";
        camp = CampEnum.friend;
        role = new Country();
        hp=maxHP = 70;
        sp=maxSP = 10;
        atk = 5;
        def = 5;
        psy = 5;
        san = 10;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 2;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 2;
        luckyValue = 0;
    }
}
