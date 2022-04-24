using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WangXiFeng : AbstractCharacter
{
    public void Awake()
    {
        characterID = 4;
        gender = GenderEnum.girl;
        wordName = "王熙凤";
        bookName = BookNameEnum.HongLouMeng;
        criticalSpeak = "你这赖狗扶不上墙的种子";
        deadSpeak = "纵我机关算尽……";
        camp = CampEnum.all;
        role = new Parents();
        hp=maxHP = 50;
        sp=maxSP = 15;
        atk = 10;
        def = 1;
        psy = 10;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 2;
        luckyValue = 0;
    }
}
